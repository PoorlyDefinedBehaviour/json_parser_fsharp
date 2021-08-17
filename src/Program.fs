module Program

open FSharp.Text.Lexing
open Lexer
open Parser

let parse input =
  Parser.start Lexer.tokenstream (LexBuffer<char>.FromString input)


[<EntryPoint>]
let main _ =
  printfn "%A" (parse "123")

  0
