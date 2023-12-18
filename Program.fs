open mainloop
open TextEditor


// Text Editor In F#
// This Really Sucks Doesn't it?



[<EntryPoint>]
let main argv =
    let ver: float = 0.1
    printfn "------------------------"
    printfn "Shitty Text-Editor v%0.1f" ver
    printfn "------------------------\n\n"
    let mutable filenam = ""
    try 
        filenam <- argv.[0]
    with | _ -> 
        filenam <- "file.txt"
    let init: TextEditor = {index = 0; filename = filenam}
    let update = 0
    let result = mainloop update init

    printfn "Text Editor Closed Successfully, %d" result
    0
