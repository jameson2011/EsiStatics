#load ".fake/build.fsx/intellisense.fsx"
open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators
open Fake.DotNet.NuGet
open Fake.SystemHelper

// AP: Build.SourceBranch (refs/head/...) or Build.SourceBranchName
let branchName() = match Fake.Core.Environment.environVarOrNone "APPVEYOR_REPO_BRANCH" with
                    | None -> (Fake.Core.Environment.environVarOrNone "BUILD_SOURCEBRANCH")
                    | x -> x

// AP: Build.BuildNumber
let version = (match Fake.Core.Environment.environVarOrNone "APPVEYOR_BUILD_VERSION" with
                | None -> Fake.Core.Environment.environVarOrNone "BUILD_BUILDNUMBER"
                | x -> x)|> Option.defaultValue "0.0.0.1"

let packageVersion =    let suffix = match branchName() with
                                        | Some "master" 
                                        | Some "refs/head/master" -> ""
                                        | None 
                                        | Some _ -> "-preview"
                        sprintf "%s%s" version suffix


let buildDir = "./build/"
let buildLibDir = buildDir + "lib/"
let buildTestsDir = buildDir + "tests/"
let nupkgsDir = "./nupkgs"

let nugetExePath = ".\\.tools\\nuget\\nuget.exe"
let nuspecFile = "EsiStatics.nuspec"
let nugetApiKey() = Fake.Core.Environment.environVarOrNone "NUGET_API_KEY"


let buildOptions = fun (opts: DotNet.BuildOptions) -> 
                                let props = ("AssemblyVersion", version) 
                                                :: ("AssemblyFileVersion", version) 
                                                :: opts.MSBuildParams.Properties 
                                { opts with
                                    Configuration = DotNet.BuildConfiguration.Release
                                    OutputPath = buildLibDir |> Path.combine "../../" |> Some
                                    MSBuildParams = { opts.MSBuildParams with Properties = props }
                                    }

let testOptions = fun (opts: DotNet.TestOptions) ->
                                { opts with
                                    Configuration = DotNet.BuildConfiguration.Release
                                    Output = buildTestsDir |> Path.combine "../../" |> Some
                                    }

let nugetOptions = fun (p:Fake.DotNet.NuGet.NuGet.NuGetParams) ->  
                                { p with 
                                    Version = packageVersion;
                                    ToolPath = nugetExePath;
                                    OutputPath = nupkgsDir;
                                    WorkingDir = ".\\"
                                } 

let nugetPushOptions = fun (apiKey) (p:Fake.DotNet.NuGet.NuGet.NuGetParams) ->  
                                { p with 
                                    PublishUrl = "https://www.nuget.org";
                                    AccessKey = apiKey;
                                    ToolPath = nugetExePath;
                                    WorkingDir = ".\\";
                                }                

Trace.log (branchName() 
            |> Option.defaultValue "Unknown"
            |> sprintf "Branch: %s")
Trace.log (version        |> sprintf "Build Version: %s")
Trace.log (packageVersion |> sprintf "Package %s")


Target.create "Clean" (fun _ ->
    !! "src/**/bin"
    ++ "src/**/obj"
    ++ buildDir
    ++ buildLibDir
    ++ buildTestsDir
    ++ nupkgsDir
    |> Shell.cleanDirs 
    
    Fake.IO.Directory.ensure nupkgsDir
)


Target.create "Build Data" (fun _ ->
    !! "src/**/EsiStatics.Data.sln"
    |> Seq.iter (DotNet.build buildOptions) 
)

Target.create "Build Facade" (fun _ ->
    !! "src/**/EsiStatics.Facade.sln"
    |> Seq.iter (DotNet.build buildOptions) 
)

Target.create "Test" (fun _ -> 
    !! "src/**/*.UnitTests.fsproj"
    ++ "src/**/*.UnitTests.csproj"
    |> Seq.iter (DotNet.test testOptions))

Target.create "Nuget Package" (fun _ -> 
    !! nuspecFile 
    |> Seq.iter (Fake.DotNet.NuGet.NuGet.NuGetPackDirectly nugetOptions))

Target.create "Nuget Push" (fun _ -> 
    match nugetApiKey() with
    | Some k -> k |> nugetPushOptions |> Fake.DotNet.NuGet.NuGet.NuGetPublish 
    | None -> Trace.log "No Nuget key set."
    )

Target.create "All" ignore

"Clean"
  ==> "Build Data"
  ==> "Build Facade"
  ==> "Test"
  ==> "Nuget Package"
  ==> "All"

Target.runOrDefault "All"
