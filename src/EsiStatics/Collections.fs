namespace EsiStatics

open System.Collections.Generic

type internal MutablePriorityQueue<'k,'v>()=

    let queues = new SortedList<'k, Queue<'v>>()

    let getCreateQueue(key: 'k) =
        let exists,q = queues.TryGetValue(key)
        if not exists then 
            let q = new Queue<'v>()
            queues.Add(key, q)
            q
        else q
                    
    let push key value =
        let q = getCreateQueue key
        q.Enqueue value
        
    let pop() =
        match queues |> Seq.tryHead with
        | Some kvp ->   let q = kvp.Value
                        let result = q.Dequeue()

                        if q.Count = 0 then
                            queues.RemoveAt(0) |> ignore
                        
                        Some (kvp.Key, result)
        | None ->       None
        
    let count() =
        queues.Values |> Seq.sumBy (fun xs -> xs.Count)

    member this.Push(key, value) = 
        push key value
        this

    member this.Pop() = pop()

    member this.Count() = count()

