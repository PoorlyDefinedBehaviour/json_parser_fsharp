module Program

open FSharp.Text.Lexing
open System
open Lexer
open Parser

let parse input =
  let lexbuf = LexBuffer<char>.FromString input

  try
    Parser.start Lexer.tokenstream lexbuf
  with
  | e ->
    let line = lexbuf.EndPos.Line
    let column = lexbuf.EndPos.Column
    let lastToken = String lexbuf.Lexeme
    printf "Parser error at line %d, column %d:\n" line column
    printf "Last loken: %s\n" lastToken
    printf "Error: %A\n" e
    printf "\n"
    exit 1

[<EntryPoint>]
let main _ =
  let json =
    """
    {
      "id": 1,
      "name": "Leanne Graham",
      "username": "Bret",
      "email": "Sincere@april.biz",
      "address": {
        "street": "Kulas Light",
        "suite": "Apt. 556",
        "city": "Gwenborough",
        "zipcode": "92998-3874",
        "geo": {
          "lat": "-37.3159",
          "lng": "81.1496"
        }
      },
      "phone": "1-770-736-8031 x56442",
      "website": "hildegard.org",
      "company": {
        "name": "Romaguera-Crona",
        "catchPhrase": "Multi-layered client-server neural-net",
        "bs": "harness real-time e-markets"
      }
    }
    """

  printfn "%A" (parse json)
  // Object
  // (map
  //    [("address",
  //      Object
  //        (map
  //           [("city", String "Gwenborough");
  //            ("geo",
  //             Object
  //               (map [("lat", String "-37.3159"); ("lng", String "81.1496")]));
  //            ("street", String "Kulas Light"); ("suite", String "Apt. 556");
  //            ("zipcode", String "92998-3874")]));
  //     ("company",
  //      Object
  //        (map
  //           [("bs", String "harness real-time e-markets");
  //            ("catchPhrase", String "Multi-layered client-server neural-net");
  //            ("name", String "Romaguera-Crona")]));
  //     ("email", String "Sincere@april.biz"); ("id", Int 1);
  //     ("name", String "Leanne Graham");
  //     ("phone", String "1-770-736-8031 x56442"); ("username", String "Bret");
  //     ("website", String "hildegard.org")])

  0
