open System
//9g0
///readFile  have to mistakes need to fix



let readFile (fileName:string) : string option =
 let reader =
    try
     Some (System.IO.File.OpenText fileName)
    with
     |_-> None

 if reader.IsSome then
   Some ((reader.Value).ReadToEnd)
 else
   None

printfn "%s" (readFile (readNWrite.fs)).Value
  
 
 
