[<AutoOpen>]
module FatSlack.Log

open System
open System.Diagnostics

let private tracelog (text: string) = Trace.WriteLine(text)
let logger = ref tracelog
let tracefn format = Printf.kprintf !logger format

