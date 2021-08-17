// Implementation file for parser generated by fsyacc
module Parser
#nowarn "64";; // turn off warnings that type variables used in production annotations are instantiated to concrete type
open FSharp.Text.Lexing
open FSharp.Text.Parsing.ParseHelpers
# 1 "./src/Parser.fsy"

open Json

# 10 "src/Parser.fs"
// This type is the type of tokens accepted by the parser
type token = 
  | EOF
  | COMMA
  | RIGHTBRACKET
  | LEFTBRACKET
  | FLOAT of (float)
  | INT of (int)
  | RIGHTBRACE
  | LEFTBRACE
// This type is used to give symbolic names to token indexes, useful for error messages
type tokenId = 
    | TOKEN_EOF
    | TOKEN_COMMA
    | TOKEN_RIGHTBRACKET
    | TOKEN_LEFTBRACKET
    | TOKEN_FLOAT
    | TOKEN_INT
    | TOKEN_RIGHTBRACE
    | TOKEN_LEFTBRACE
    | TOKEN_end_of_input
    | TOKEN_error
// This type is used to give symbolic names to token indexes, useful for error messages
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_value
    | NONTERM_list
    | NONTERM_list_values
    | NONTERM_end

// This function maps tokens to integer indexes
let tagOfToken (t:token) = 
  match t with
  | EOF  -> 0 
  | COMMA  -> 1 
  | RIGHTBRACKET  -> 2 
  | LEFTBRACKET  -> 3 
  | FLOAT _ -> 4 
  | INT _ -> 5 
  | RIGHTBRACE  -> 6 
  | LEFTBRACE  -> 7 

// This function maps integer indexes to symbolic token ids
let tokenTagToTokenId (tokenIdx:int) = 
  match tokenIdx with
  | 0 -> TOKEN_EOF 
  | 1 -> TOKEN_COMMA 
  | 2 -> TOKEN_RIGHTBRACKET 
  | 3 -> TOKEN_LEFTBRACKET 
  | 4 -> TOKEN_FLOAT 
  | 5 -> TOKEN_INT 
  | 6 -> TOKEN_RIGHTBRACE 
  | 7 -> TOKEN_LEFTBRACE 
  | 10 -> TOKEN_end_of_input
  | 8 -> TOKEN_error
  | _ -> failwith "tokenTagToTokenId: bad token"

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
let prodIdxToNonTerminal (prodIdx:int) = 
  match prodIdx with
    | 0 -> NONTERM__startstart 
    | 1 -> NONTERM_start 
    | 2 -> NONTERM_value 
    | 3 -> NONTERM_value 
    | 4 -> NONTERM_value 
    | 5 -> NONTERM_list 
    | 6 -> NONTERM_list 
    | 7 -> NONTERM_list_values 
    | 8 -> NONTERM_list_values 
    | 9 -> NONTERM_end 
    | _ -> failwith "prodIdxToNonTerminal: bad production index"

let _fsyacc_endOfInputTag = 10 
let _fsyacc_tagOfErrorTerminal = 8

// This function gets the name of a token as a string
let token_to_string (t:token) = 
  match t with 
  | EOF  -> "EOF" 
  | COMMA  -> "COMMA" 
  | RIGHTBRACKET  -> "RIGHTBRACKET" 
  | LEFTBRACKET  -> "LEFTBRACKET" 
  | FLOAT _ -> "FLOAT" 
  | INT _ -> "INT" 
  | RIGHTBRACE  -> "RIGHTBRACE" 
  | LEFTBRACE  -> "LEFTBRACE" 

// This function gets the data carried by a token as an object
let _fsyacc_dataOfToken (t:token) = 
  match t with 
  | EOF  -> (null : System.Object) 
  | COMMA  -> (null : System.Object) 
  | RIGHTBRACKET  -> (null : System.Object) 
  | LEFTBRACKET  -> (null : System.Object) 
  | FLOAT _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | INT _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | RIGHTBRACE  -> (null : System.Object) 
  | LEFTBRACE  -> (null : System.Object) 
let _fsyacc_gotos = [| 0us; 65535us; 1us; 65535us; 0us; 1us; 3us; 65535us; 0us; 2us; 6us; 10us; 11us; 12us; 3us; 65535us; 0us; 5us; 6us; 5us; 11us; 5us; 1us; 65535us; 6us; 8us; 0us; 65535us; |]
let _fsyacc_sparseGotoTableRowOffsets = [|0us; 1us; 3us; 7us; 11us; 13us; |]
let _fsyacc_stateToProdIdxsTableElements = [| 1us; 0us; 1us; 0us; 1us; 1us; 1us; 2us; 1us; 3us; 1us; 4us; 2us; 5us; 6us; 1us; 5us; 2us; 6us; 8us; 1us; 6us; 1us; 7us; 1us; 8us; 1us; 8us; |]
let _fsyacc_stateToProdIdxsTableRowOffsets = [|0us; 2us; 4us; 6us; 8us; 10us; 12us; 15us; 17us; 20us; 22us; 24us; 26us; |]
let _fsyacc_action_rows = 13
let _fsyacc_actionTableElements = [|3us; 32768us; 3us; 6us; 4us; 4us; 5us; 3us; 0us; 49152us; 0us; 16385us; 0us; 16386us; 0us; 16387us; 0us; 16388us; 4us; 32768us; 2us; 7us; 3us; 6us; 4us; 4us; 5us; 3us; 0us; 16389us; 2us; 32768us; 1us; 11us; 2us; 9us; 0us; 16390us; 0us; 16391us; 3us; 32768us; 3us; 6us; 4us; 4us; 5us; 3us; 0us; 16392us; |]
let _fsyacc_actionTableRowOffsets = [|0us; 4us; 5us; 6us; 7us; 8us; 9us; 14us; 15us; 18us; 19us; 20us; 24us; |]
let _fsyacc_reductionSymbolCounts = [|1us; 1us; 1us; 1us; 1us; 2us; 3us; 1us; 3us; 1us; |]
let _fsyacc_productionToNonTerminalTable = [|0us; 1us; 2us; 2us; 2us; 3us; 3us; 4us; 4us; 5us; |]
let _fsyacc_immediateActions = [|65535us; 49152us; 16385us; 16386us; 16387us; 16388us; 65535us; 16389us; 65535us; 16390us; 16391us; 65535us; 16392us; |]
let _fsyacc_reductions ()  =    [| 
# 121 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Value in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
                      raise (FSharp.Text.Parsing.Accept(Microsoft.FSharp.Core.Operators.box _1))
                   )
                 : 'gentype__startstart));
# 130 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_value in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 27 "./src/Parser.fsy"
                                 _1 
                   )
# 27 "./src/Parser.fsy"
                 : Value));
# 141 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> int in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 30 "./src/Parser.fsy"
                               Int _1 
                   )
# 30 "./src/Parser.fsy"
                 : 'gentype_value));
# 152 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> float in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 31 "./src/Parser.fsy"
                                 Float _1 
                   )
# 31 "./src/Parser.fsy"
                 : 'gentype_value));
# 163 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_list in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 32 "./src/Parser.fsy"
                                _1 
                   )
# 32 "./src/Parser.fsy"
                 : 'gentype_value));
# 174 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 35 "./src/Parser.fsy"
                                                    List [] 
                   )
# 35 "./src/Parser.fsy"
                 : 'gentype_list));
# 184 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> 'gentype_list_values in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 36 "./src/Parser.fsy"
                                                                List _2 
                   )
# 36 "./src/Parser.fsy"
                 : 'gentype_list));
# 195 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_value in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 39 "./src/Parser.fsy"
                                 [_1] 
                   )
# 39 "./src/Parser.fsy"
                 : 'gentype_list_values));
# 206 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_list_values in
            let _3 = parseState.GetInput(3) :?> 'gentype_value in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 40 "./src/Parser.fsy"
                                                   _3 :: _1 
                   )
# 40 "./src/Parser.fsy"
                 : 'gentype_list_values));
# 218 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 43 "./src/Parser.fsy"
                                3 
                   )
# 43 "./src/Parser.fsy"
                 : 'gentype_end));
|]
# 229 "src/Parser.fs"
let tables : FSharp.Text.Parsing.Tables<_> = 
  { reductions= _fsyacc_reductions ();
    endOfInputTag = _fsyacc_endOfInputTag;
    tagOfToken = tagOfToken;
    dataOfToken = _fsyacc_dataOfToken; 
    actionTableElements = _fsyacc_actionTableElements;
    actionTableRowOffsets = _fsyacc_actionTableRowOffsets;
    stateToProdIdxsTableElements = _fsyacc_stateToProdIdxsTableElements;
    stateToProdIdxsTableRowOffsets = _fsyacc_stateToProdIdxsTableRowOffsets;
    reductionSymbolCounts = _fsyacc_reductionSymbolCounts;
    immediateActions = _fsyacc_immediateActions;
    gotos = _fsyacc_gotos;
    sparseGotoTableRowOffsets = _fsyacc_sparseGotoTableRowOffsets;
    tagOfErrorTerminal = _fsyacc_tagOfErrorTerminal;
    parseError = (fun (ctxt:FSharp.Text.Parsing.ParseErrorContext<_>) -> 
                              match parse_error_rich with 
                              | Some f -> f ctxt
                              | None -> parse_error ctxt.Message);
    numTerminals = 11;
    productionToNonTerminalTable = _fsyacc_productionToNonTerminalTable  }
let engine lexer lexbuf startState = tables.Interpret(lexer, lexbuf, startState)
let start lexer lexbuf : Value =
    engine lexer lexbuf 0 :?> _
