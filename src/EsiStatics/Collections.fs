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



// From https://lorgonblog.wordpress.com/2010/02/14/how-to-_really_-be-an-evil-genius-with-f/
[<AllowNullLiteral>]
type internal MutableTrieNode<'a>(charmap: Map<char,int>)=    
    
    let nextNode = Array.create charmap.Count null
    let nextNodeIdx (c:char) = charmap.[c]
    
    let mutable isEndOfWord = false
    let mutable nodeValue = Unchecked.defaultof<'a>
    
    member this.IsEndOfWord = isEndOfWord
   
    member this.Value =
        match isEndOfWord with
        | true -> Some nodeValue
        | _ -> None

    member this.Children()=
        nextNode |> Seq.filter (fun n -> n <> null)

    member this.Item    with get(c:char) = nextNode.[nextNodeIdx c] 
                        and private set(c:char) value = nextNode.[nextNodeIdx c] <- value

    member this.Add(word: string, value: 'a)=
        let word = String.lower word
        assert(word |> Seq.forall charmap.ContainsKey)
        
        this.Add(word, value, 0)


    member private this.Add(word:string, (value: 'a), idx) =
        if idx = word.Length then 
            isEndOfWord <- true
            nodeValue <- value 
        else    
            let k = word.[idx]            
            match this.[k] with 
            | null ->   let newNode = new MutableTrieNode<'a>(charmap)
                        newNode.Add(word, value, idx+1)
                        this.[k] <- newNode
            | node ->   node.Add(word, value, idx+1)


type ReadonlyTrie<'a>(items: seq<string * 'a>)=
    let charArray (value: string) = value.ToCharArray()

    let charmap = items |> argNull "items"
                        |> Seq.collect (fst >> String.lower >> charArray)
                        |> Seq.distinct 
                        |> Seq.sort
                        |> Seq.mapi (fun x s -> (s,x))
                        |> Map.ofSeq
    
    let rootNode = new MutableTrieNode<'a>(charmap)
    
    let addValue (word: string, value: 'a) =
        rootNode.Add(word, value)
    
    do items |> Seq.iter addValue
    
    member this.Find(search: string) =
        
        let keys = search 
                    |> argNull "search"
                    |> String.lower
                    |> charArray 
                    |> List.ofSeq
        
        let accum (node: MutableTrieNode<'a>) result =
            if node.Value.IsSome then
                node.Value.Value :: result
            else result

        let rec collect (node: MutableTrieNode<'a>) todo result = 
            let result = accum node result
            let children = node.Children() |> List.ofSeq
            
            match children @ todo with
            | [] ->     result
            | h::t ->   collect h t result
            
        let rec find keys (node: MutableTrieNode<'a>) result =
            match keys with
            | [] ->     collect node [] result |> List.rev
            | k::ks ->  let nextNode = node.Item k
                        if nextNode = null then result
                        else                    find ks nextNode result

        
        if keys |> Seq.filter (charmap.ContainsKey >> not) |> Seq.isEmpty then
            find keys rootNode []
        else []

    static member Create<'a>(items: seq<string * 'a>)=
        new ReadonlyTrie<'a>(items)
