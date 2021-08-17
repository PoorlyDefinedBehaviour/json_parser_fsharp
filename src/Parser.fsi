// Signature file for parser generated by fsyacc
module Parser
type token = 
  | EOF
  | FLOAT of (float)
  | INT of (int)
  | RIGHTBRACE
  | LEFTBRACE
type tokenId = 
    | TOKEN_EOF
    | TOKEN_FLOAT
    | TOKEN_INT
    | TOKEN_RIGHTBRACE
    | TOKEN_LEFTBRACE
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_end
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> FSharp.Text.Lexing.LexBuffer<'cty> -> ( int ) 
