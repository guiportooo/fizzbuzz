#load "Library.fs"

open FizzBuzz
open Validator

Parser.tryParse "2"
Parser.tryParse "Tomato"

ValidNumber.isValidNumber 1
ValidNumber.isValidNumber 4000
ValidNumber.isValidNumber 0
ValidNumber.isValidNumber 4001

ValidNumber.isValidNumber 20
|> Option.map FizzBuzz.getFizzBuzzString
