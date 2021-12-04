open System

let url2Stream url =
  let uri = System.Uri url
  let request = System.Net.WebRequest.Create uri
  let response = request.GetResponse ()
  response.GetResponseStream ()

let readUrl url =
   try 
       let stream = url2Stream url
       let reader = new System.IO.StreamReader(stream)
       reader.ReadToEnd ()
   with
       | _-> printfn "%s" ex.Message; "Error"

let countLinks  "url:string" : int =
    match readUrl url with
       | "Error" -> 0
       |_-> 


