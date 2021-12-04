open System
open System.Text
///9g3

///<summary>a help function to fetch an internet webpage as stream</summary>
/// <param name="url">url of a webpage. string.</param>
/// <returns>a stream</returns>
let url2Stream url =
  let uri = System.Uri url
  let request = System.Net.WebRequest.Create uri
  let response = request.GetResponse ()
  response.GetResponseStream ()
///<summary>an help function to read stream</summary>
/// <param name="url">url of the webpage. string </param>
/// <returns>the webpage content as a string</returns>
let readUrl url =
   try 
       let stream = url2Stream url
       let reader = new System.IO.StreamReader(stream)
       reader.ReadToEnd ()
   with
       | ex-> printfn "%s" ex.Message; "Error"

///<summary>count how many links a webpage uses</summary>
/// <param name="url">url of a webpage. string.</param>
/// <returns>the number of the links in the webpage</returns>

let countLinks  (url:string) : int =
    let r = RegularExpressions.Regex "href=.*"
    let s = readUrl url
    let mutable count:int = 0
    match s with
       | "Error" -> 0
       | _-> for elm in (s.Split()) do
                     if r.IsMatch elm then
                                  count<-count+1
             count
//call the function
printfn " %s  has %A links" "https://www.dr.dk/"  (countLinks "https://www.dr.dk/")


