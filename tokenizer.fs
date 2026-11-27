module Tokenizer

open System
open System.Globalization

/// Converts a single character to its cleaned form:
/// - letters/digits (English, Arabic, ...) -> lowercase
/// - apostrophe -> kept (so "don't" stays one word)
/// - Arabic diacritics (tashkeel) -> removed
/// - anything else (spaces, punctuation, newlines) -> a space separator
let private cleanChar (c: char) : string =
    match c with
    | _ when Char.IsLetterOrDigit c -> string (Char.ToLowerInvariant c)
    | '\'' -> "'"
    | _ when CharUnicodeInfo.GetUnicodeCategory c = UnicodeCategory.NonSpacingMark -> ""
    | _ -> " "

/// Splits text into a list of clean lowercase words.
/// Example: "Hello, World! Hello." -> ["hello"; "world"; "hello"]
let tokenize (text: string) : string list =
    match text with
    | null
    | "" -> []
    | _ ->
        text
        |> Seq.map cleanChar
        |> String.concat ""
        |> fun cleaned -> cleaned.Split(' ', StringSplitOptions.RemoveEmptyEntries)
        |> Array.map (fun word -> word.Trim('\''))
        |> Array.filter (fun word -> word <> "")
        |> Array.toList