module Program

open System
open System.Windows.Forms

[<EntryPoint>]
[<STAThread>]
let main argv =
    Application.EnableVisualStyles()
    let form = new Form(Text = "Text Analyzer", Width = 800, Height = 600)
    Application.Run(form)
    0