#load "utilities.fsx"

let inputString = "ACGTTGCATGTCGCATGATGCATGAGAGCT"

let partitioned = inputString |> Array.ofSeq |> Utilities.partition 4 1 
                              |> List.map 
                                (fun arr -> arr |> Array.Parallel.map (fun ch -> string(ch)) |> String.concat "")
let occurrences = partitioned |> Utilities.getNumberOfOccurences 
let maxNum = occurrences |> Seq.maxBy snd |> snd
let ans = occurrences |> Seq.filter (fun (st, occ) -> occ = maxNum) |> Seq.map fst

