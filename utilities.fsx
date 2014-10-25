let makeString<'a> (input : 'a array) = 
    let temp = [for value in input do
                    yield value.ToString()] 
    List.fold (fun state acc -> acc + state) "" temp

(* 
    Partitions an array into subarrays with a specified size in specified increments wrt the
    current index.

    @param partitionLength: the length of each sub-array
    @param partitionSkip: the number of elements to with each sub-array extraction
    @param xs: that array to partition
    @return: a list containing the partitions extracted from xs
*)  
let partition partitionLength partitionSkip xs  = 
    let arr = xs |> Seq.toArray
    let limit = (Array.length xs) - partitionLength - 1
    [for i in 0 .. partitionSkip .. limit do 
        yield (xs.[i .. (i + partitionLength - 1)])]

let getNumberOfOccurences xs = 
    xs |> Seq.groupBy (fun x -> x) 
       |> Seq.map (fun (elem, ys) -> elem, (Seq.length ys))

let frequences xs = 
    xs |> getNumberOfOccurences |> Map.ofSeq
       


