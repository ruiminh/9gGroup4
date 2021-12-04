open System
open System.Text

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
    let r = RegularExpressions.Regex "href=.*"
    let s = readUrl url
    let mutable count = 0
    match s with
       | "Error" -> 0
       |_-> for elm i s.Split() do
                   if r.IsMatch elm then count<-count+1
	        count


