
let complement = function 
    | 'A' -> 'T'
    | 'C' -> 'G'
    | 'G' -> 'C'
    | 'T' -> 'A'
    | _ -> failwith "Incorrect nucleotide sequence submitted"

let reverseComplement xs = 
    xs |> Seq.map (fun ch -> string(complement ch))
       |> List.ofSeq |> List.rev |> List.toSeq |> String.concat ""

