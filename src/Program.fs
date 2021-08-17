module Program

open FSharp.Text.Lexing
open Lexer

let parse input =
  let ast =
    LexBuffer<char>.FromString input
    |> Lexer.tokenstream

  ast


[<EntryPoint>]
let main _ =
  printfn "%A" (parse "-1432432")

  0
