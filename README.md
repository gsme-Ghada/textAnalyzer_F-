# Text Analyzer (F#)

A desktop application built with **F#** and **Windows Forms** that analyzes text and shows useful statistics about it. Developed as part of the PL-3 course project.

## Features

- **Input:** type or paste text directly in the GUI, or load a `.txt` file.
- **Counting:** number of words, sentences, and paragraphs.
- **Word frequency:** frequency of every word, plus the most frequently used words.
- **Readability:** average sentence length.

## Project Structure

| File | Responsibility |
|---|---|
| `tokenizer.fs` | Splits text into clean lowercase words (removes punctuation) |
| `text_input.fs` | Loads text from `.txt` files using `System.IO` |
| `counting.fs` | Counts words, sentences, and paragraphs |
| `frequency.fs` | Word frequency and top-N words |
| `readability.fs` | Average sentence length |
| `gui.fs` | Windows Forms interface |
| `Program.fs` | Entry point, connects the functions to the GUI |

> File order in `textAnalyzer_F-.fsproj` matters: `tokenizer.fs` comes first, and `gui.fs` and `Program.fs` come last.

## Requirements

- Windows
- [.NET SDK](https://dotnet.microsoft.com/download) 8.0 or later

## How to Run

```
git clone <repo-link>
cd textAnalyzer_F-
dotnet build
dotnet run
```

## Functional Programming Concepts Used

- Immutable data
- First-class functions
- Pattern matching
- Sequences (`Seq.countBy`, `Seq.sortByDescending`, `Seq.take`, ...)

## Team

| Member | Part |
|---|---|
| abdelrahman adel | GUI (`gui.fs`) |
| abdallah  | Text input (`text_input.fs`) |
| shahd | Counting (`counting.fs`) |
| ghada | Tokenizer (`tokenizer.fs`) |
| sama | Word frequency (`frequency.fs`) |
| fatma | Readability (`readability.fs`) |
| abdelrahman magdy | Integration, testing, and docs (`Program.fs`, `README.md`) |

## Git Workflow

- Each member works on their own branch (e.g. `feature/frequency`).
- Make small, regular commits.
- Open a Pull Request and merge into `main`.
