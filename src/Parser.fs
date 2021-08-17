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
  | COLON
  | COMMA
  | RIGHTBRACKET
  | LEFTBRACKET
  | STRING of (string)
  | FLOAT of (float)
  | INT of (int)
  | RIGHTBRACE
  | LEFTBRACE
// This type is used to give symbolic names to token indexes, useful for error messages
type tokenId = 
    | TOKEN_EOF
    | TOKEN_COLON
    | TOKEN_COMMA
    | TOKEN_RIGHTBRACKET
    | TOKEN_LEFTBRACKET
    | TOKEN_STRING
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
    | NONTERM_object
    | NONTERM_object_properties
    | NONTERM_end

// This function maps tokens to integer indexes
let tagOfToken (t:token) = 
  match t with
  | EOF  -> 0 
  | COLON  -> 1 
  | COMMA  -> 2 
  | RIGHTBRACKET  -> 3 
  | LEFTBRACKET  -> 4 
  | STRING _ -> 5 
  | FLOAT _ -> 6 
  | INT _ -> 7 
  | RIGHTBRACE  -> 8 
  | LEFTBRACE  -> 9 

// This function maps integer indexes to symbolic token ids
let tokenTagToTokenId (tokenIdx:int) = 
  match tokenIdx with
  | 0 -> TOKEN_EOF 
  | 1 -> TOKEN_COLON 
  | 2 -> TOKEN_COMMA 
  | 3 -> TOKEN_RIGHTBRACKET 
  | 4 -> TOKEN_LEFTBRACKET 
  | 5 -> TOKEN_STRING 
  | 6 -> TOKEN_FLOAT 
  | 7 -> TOKEN_INT 
  | 8 -> TOKEN_RIGHTBRACE 
  | 9 -> TOKEN_LEFTBRACE 
  | 12 -> TOKEN_end_of_input
  | 10 -> TOKEN_error
  | _ -> failwith "tokenTagToTokenId: bad token"

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
let prodIdxToNonTerminal (prodIdx:int) = 
  match prodIdx with
    | 0 -> NONTERM__startstart 
    | 1 -> NONTERM_start 
    | 2 -> NONTERM_value 
    | 3 -> NONTERM_value 
    | 4 -> NONTERM_value 
    | 5 -> NONTERM_value 
    | 6 -> NONTERM_value 
    | 7 -> NONTERM_list 
    | 8 -> NONTERM_list 
    | 9 -> NONTERM_list_values 
    | 10 -> NONTERM_list_values 
    | 11 -> NONTERM_object 
    | 12 -> NONTERM_object 
    | 13 -> NONTERM_object_properties 
    | 14 -> NONTERM_object_properties 
    | 15 -> NONTERM_end 
    | _ -> failwith "prodIdxToNonTerminal: bad production index"

let _fsyacc_endOfInputTag = 12 
let _fsyacc_tagOfErrorTerminal = 10

// This function gets the name of a token as a string
let token_to_string (t:token) = 
  match t with 
  | EOF  -> "EOF" 
  | COLON  -> "COLON" 
  | COMMA  -> "COMMA" 
  | RIGHTBRACKET  -> "RIGHTBRACKET" 
  | LEFTBRACKET  -> "LEFTBRACKET" 
  | STRING _ -> "STRING" 
  | FLOAT _ -> "FLOAT" 
  | INT _ -> "INT" 
  | RIGHTBRACE  -> "RIGHTBRACE" 
  | LEFTBRACE  -> "LEFTBRACE" 

// This function gets the data carried by a token as an object
let _fsyacc_dataOfToken (t:token) = 
  match t with 
  | EOF  -> (null : System.Object) 
  | COLON  -> (null : System.Object) 
  | COMMA  -> (null : System.Object) 
  | RIGHTBRACKET  -> (null : System.Object) 
  | LEFTBRACKET  -> (null : System.Object) 
  | STRING _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | FLOAT _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | INT _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | RIGHTBRACE  -> (null : System.Object) 
  | LEFTBRACE  -> (null : System.Object) 
let _fsyacc_gotos = [| 0us; 65535us; 1us; 65535us; 0us; 1us; 5us; 65535us; 0us; 2us; 8us; 12us; 13us; 14us; 20us; 21us; 25us; 26us; 5us; 65535us; 0us; 6us; 8us; 6us; 13us; 6us; 20us; 6us; 25us; 6us; 1us; 65535us; 8us; 10us; 5us; 65535us; 0us; 7us; 8us; 7us; 13us; 7us; 20us; 7us; 25us; 7us; 2us; 65535us; 15us; 17us; 22us; 23us; 0us; 65535us; |]
let _fsyacc_sparseGotoTableRowOffsets = [|0us; 1us; 3us; 9us; 15us; 17us; 23us; 26us; |]
let _fsyacc_stateToProdIdxsTableElements = [| 1us; 0us; 1us; 0us; 1us; 1us; 1us; 2us; 1us; 3us; 1us; 4us; 1us; 5us; 1us; 6us; 2us; 7us; 8us; 1us; 7us; 2us; 8us; 10us; 1us; 8us; 1us; 9us; 1us; 10us; 1us; 10us; 2us; 11us; 12us; 1us; 11us; 1us; 12us; 1us; 12us; 1us; 13us; 1us; 13us; 1us; 13us; 1us; 14us; 1us; 14us; 1us; 14us; 1us; 14us; 1us; 14us; |]
let _fsyacc_stateToProdIdxsTableRowOffsets = [|0us; 2us; 4us; 6us; 8us; 10us; 12us; 14us; 16us; 19us; 21us; 24us; 26us; 28us; 30us; 32us; 35us; 37us; 39us; 41us; 43us; 45us; 47us; 49us; 51us; 53us; 55us; |]
let _fsyacc_action_rows = 27
let _fsyacc_actionTableElements = [|5us; 32768us; 4us; 8us; 5us; 3us; 6us; 5us; 7us; 4us; 9us; 15us; 0us; 49152us; 0us; 16385us; 0us; 16386us; 0us; 16387us; 0us; 16388us; 0us; 16389us; 0us; 16390us; 6us; 32768us; 3us; 9us; 4us; 8us; 5us; 3us; 6us; 5us; 7us; 4us; 9us; 15us; 0us; 16391us; 2us; 32768us; 2us; 13us; 3us; 11us; 0us; 16392us; 0us; 16393us; 5us; 32768us; 4us; 8us; 5us; 3us; 6us; 5us; 7us; 4us; 9us; 15us; 0us; 16394us; 3us; 32768us; 2us; 22us; 5us; 19us; 8us; 16us; 0us; 16395us; 1us; 32768us; 8us; 18us; 0us; 16396us; 1us; 32768us; 1us; 20us; 5us; 32768us; 4us; 8us; 5us; 3us; 6us; 5us; 7us; 4us; 9us; 15us; 0us; 16397us; 2us; 32768us; 2us; 22us; 5us; 19us; 1us; 32768us; 5us; 24us; 1us; 32768us; 1us; 25us; 5us; 32768us; 4us; 8us; 5us; 3us; 6us; 5us; 7us; 4us; 9us; 15us; 0us; 16398us; |]
let _fsyacc_actionTableRowOffsets = [|0us; 6us; 7us; 8us; 9us; 10us; 11us; 12us; 13us; 20us; 21us; 24us; 25us; 26us; 32us; 33us; 37us; 38us; 40us; 41us; 43us; 49us; 50us; 53us; 55us; 57us; 63us; |]
let _fsyacc_reductionSymbolCounts = [|1us; 1us; 1us; 1us; 1us; 1us; 1us; 2us; 3us; 1us; 3us; 2us; 3us; 3us; 5us; 1us; |]
let _fsyacc_productionToNonTerminalTable = [|0us; 1us; 2us; 2us; 2us; 2us; 2us; 3us; 3us; 4us; 4us; 5us; 5us; 6us; 6us; 7us; |]
let _fsyacc_immediateActions = [|65535us; 49152us; 16385us; 16386us; 16387us; 16388us; 16389us; 16390us; 65535us; 16391us; 65535us; 16392us; 16393us; 65535us; 16394us; 65535us; 16395us; 65535us; 16396us; 65535us; 65535us; 16397us; 65535us; 65535us; 65535us; 65535us; 16398us; |]
let _fsyacc_reductions ()  =    [| 
# 141 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Value in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
                      raise (FSharp.Text.Parsing.Accept(Microsoft.FSharp.Core.Operators.box _1))
                   )
                 : 'gentype__startstart));
# 150 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_value in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 29 "./src/Parser.fsy"
                                 _1 
                   )
# 29 "./src/Parser.fsy"
                 : Value));
# 161 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> string in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 32 "./src/Parser.fsy"
                                  String _1 
                   )
# 32 "./src/Parser.fsy"
                 : 'gentype_value));
# 172 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> int in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 33 "./src/Parser.fsy"
                               Int _1 
                   )
# 33 "./src/Parser.fsy"
                 : 'gentype_value));
# 183 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> float in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 34 "./src/Parser.fsy"
                                 Float _1 
                   )
# 34 "./src/Parser.fsy"
                 : 'gentype_value));
# 194 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_list in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 35 "./src/Parser.fsy"
                                _1 
                   )
# 35 "./src/Parser.fsy"
                 : 'gentype_value));
# 205 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_object in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 36 "./src/Parser.fsy"
                                  _1 
                   )
# 36 "./src/Parser.fsy"
                 : 'gentype_value));
# 216 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 39 "./src/Parser.fsy"
                                                    List [] 
                   )
# 39 "./src/Parser.fsy"
                 : 'gentype_list));
# 226 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> 'gentype_list_values in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 40 "./src/Parser.fsy"
                                                                List (List.rev _2) 
                   )
# 40 "./src/Parser.fsy"
                 : 'gentype_list));
# 237 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_value in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 43 "./src/Parser.fsy"
                                 [_1] 
                   )
# 43 "./src/Parser.fsy"
                 : 'gentype_list_values));
# 248 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_list_values in
            let _3 = parseState.GetInput(3) :?> 'gentype_value in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 44 "./src/Parser.fsy"
                                                   _3 :: _1 
                   )
# 44 "./src/Parser.fsy"
                 : 'gentype_list_values));
# 260 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 47 "./src/Parser.fsy"
                                                Object Map.empty 
                   )
# 47 "./src/Parser.fsy"
                 : 'gentype_object));
# 270 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> 'gentype_object_properties in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 48 "./src/Parser.fsy"
                                                                  Object (Map _2) 
                   )
# 48 "./src/Parser.fsy"
                 : 'gentype_object));
# 281 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> string in
            let _3 = parseState.GetInput(3) :?> 'gentype_value in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 51 "./src/Parser.fsy"
                                              [(_1, _3)] 
                   )
# 51 "./src/Parser.fsy"
                 : 'gentype_object_properties));
# 293 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> 'gentype_object_properties in
            let _3 = parseState.GetInput(3) :?> string in
            let _5 = parseState.GetInput(5) :?> 'gentype_value in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 52 "./src/Parser.fsy"
                                                                      (_3, _5) :: _2 
                   )
# 52 "./src/Parser.fsy"
                 : 'gentype_object_properties));
# 306 "src/Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 55 "./src/Parser.fsy"
                                3 
                   )
# 55 "./src/Parser.fsy"
                 : 'gentype_end));
|]
# 317 "src/Parser.fs"
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
    numTerminals = 13;
    productionToNonTerminalTable = _fsyacc_productionToNonTerminalTable  }
let engine lexer lexbuf startState = tables.Interpret(lexer, lexbuf, startState)
let start lexer lexbuf : Value =
    engine lexer lexbuf 0 :?> _
