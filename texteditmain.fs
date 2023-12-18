module TextEditMain

open System
open TextEditor
open filewriter

let rec texteditmain i (textedittype: TextEditor) =
    
    match i with    
    | 1 -> true
    | _ -> 
        if textedittype.filename = "file.txt" then
            printf "Enter Filename: "
            let option = Console.ReadLine()
            printf "\n"
            textedittype.filename <- option 
        printf "%d | -> " textedittype.index 
        let input = Console.ReadLine()
        match input with
        | ":quit" -> 
            printfn "Writing Buffer Content Into File"
            texteditmain 1 textedittype
        | ":reset" ->
            printfn "Resetting File Buffer..."
            textedittype.index <- 0
            texteditmain 0 textedittype
        | ":help" ->
            printfn "Commands:\n:quit - quits the editor\n:reset - resets the file and erases all change"
            texteditmain 0 textedittype
        | _ -> 
            textedittype.index <- textedittype.index + 1
            match textedittype.index with
            | 1 -> 
                try filewriterbeginning textedittype.filename input
                with | ex -> 
                            printfn "Failed Writing File"
                            
            | _ -> try filewriter textedittype.filename input
                   with | ex -> 
                            printfn "Failed Writing File"

            
            texteditmain 0 textedittype

