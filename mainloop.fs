module mainloop

open TextEditMain
open TextEditor



let rec mainloop (i: int) (textedittype: TextEditor)  =
    match i with
        | 1 -> 0
        | 0 ->
            let result = texteditmain 0 textedittype
            if result then mainloop 1 textedittype
            else mainloop 0 textedittype
        | _ -> failwith "Invalid argument"
