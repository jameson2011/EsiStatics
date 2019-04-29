namespace EsiStatics

open System.Collections.Generic

type MutablePriorityQueue<'k,'v>()=

    let dictionary = new SortedDictionary<'k,  Queue<'v>>()
    
    let getCreateQueue(key: 'k) =
        let exists,q = dictionary.TryGetValue(key)
        if not exists then 
            let q = new Queue<'v>()
            dictionary.Add(key, q)
            q
        else q
                    
    let push key value =
        let q = getCreateQueue key
        q.Enqueue value
        
    let pop() =
        match dictionary.Keys |> Seq.tryHead with
        | Some k ->     let q = dictionary.[k]
                        let result = q.Dequeue()

                        if q.Count = 0 then
                            dictionary.Remove(k) |> ignore
                        
                        Some result
        | None ->       None
        
    let count() =
        dictionary.Values |> Seq.sumBy (fun xs -> xs.Count)

    member this.Push(key, value) = push key value

    member this.Pop() = pop()

    member this.Count() = count()