module filewriter

open System.IO



let filewriter (filename: string) (buffer: string) =
       use writer = new StreamWriter(filename, true)
       writer.Write(buffer)
       writer.Write("\n")
       



let filewriterbeginning (filename: string) (buffer: string) =
       use writer = new StreamWriter(filename, false)
       writer.Write(buffer)
       writer.Write("\n")
       