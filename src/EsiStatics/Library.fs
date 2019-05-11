namespace EsiStatics


module Library=
    open System
    open System.Reflection
    
    let private jitAssembly(asmName: string)=
        
        let getMethods (t: Type)=
            t.GetRuntimeMethods()
            
        let isMatch (m: MethodInfo)=
            (m.Attributes &&& MethodAttributes.Static) = MethodAttributes.Static
            
        let methods = System.Reflection.Assembly.Load(asmName).GetTypes()
                        |> Seq.collect getMethods
                        |> Seq.filter isMatch
                        |> Array.ofSeq

        methods 
            |> Array.Parallel.iter (fun mi -> System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(mi.MethodHandle) )
        
    [<CompiledName("InitialiseUniverse")>]
    let initUniverse () =
        jitAssembly("EsiStatics.Data.Entities")
        jitAssembly("EsiStatics.Data.Moons")
        jitAssembly("EsiStatics.Data.Universe")

    [<CompiledName("InitialiseItemTypes")>]
    let initItemTypes () =
        jitAssembly("EsiStatics.Data.ItemTypes")
        
        

