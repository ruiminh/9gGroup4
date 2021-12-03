open readNWrite
open System
///an application of cat function, that take in command line argument.
[<EntryPoint>]
let main args =
  let filenames = List.ofArray args
  if (cat filenames).IsSome then
     printfn "%s" (cat filenames).Value
     0
   else
     1
