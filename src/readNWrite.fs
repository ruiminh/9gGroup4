open System
//9g0
///<summary>readFile function, akes a filename and returns the contents of the text file as a string option</summary>
/// <param name="fileName">name of the file. string.</param>
/// <returns>the contents of the text file as a string option</returns>

let readFile (fileName:string) : string option =
  try 
     let reader = System.IO.File.OpenText fileName
     let str = reader.ReadToEnd()
     Some str
  with
    |ex -> printfn "%s" ex.Message; None
     



  
 
 
