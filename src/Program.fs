module Program

open FSharp.Text.Lexing
open Lexer
open Parser

let parse input =
  Parser.start Lexer.tokenstream (LexBuffer<char>.FromString input)

[<EntryPoint>]
let main _ =
  let json =
    """
    {
      "id": "a04d0943-e0d9-4da1-a0e1-b521851a2ceb"
    }
    """

  printfn "%A" (parse json)

  0
