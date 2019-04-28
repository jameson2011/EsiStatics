#load ".fake/build.fsx/intellisense.fsx"
open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators
open Fake.DotNet.NuGet
open Fake.SystemHelper

let version = "0.0.2.0"
let packageVersion = "0.0.1"
let buildDir = "./build/"
let buildLibDir = buildDir + "lib/"
let buildTestsDir = buildDir + "tests/"
let nupkgsDir = "./nupkgs"

let nugetExePath = ".\\.tools\\nuget\\nuget.exe"
let nuspecFile = "EsiStatics.nuspec"

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
    |> Seq.iter (DotNet.test testOptions))

Target.create "Nuget" (fun _ -> 
    !! nuspecFile 
    |> Seq.iter (Fake.DotNet.NuGet.NuGet.NuGetPackDirectly 
                        (fun p2 ->  { p2 with Version = packageVersion;
                                                ToolPath = nugetExePath;
                                                OutputPath = nupkgsDir;
                                                WorkingDir = ".\\"
                                            }) ))

Target.create "All" ignore

"Clean"
  ==> "Build Data"
  ==> "Build Facade"
  ==> "Test"
  ==> "Nuget"
  ==> "All"

Target.runOrDefault "All"
