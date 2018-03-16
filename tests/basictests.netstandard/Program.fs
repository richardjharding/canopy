// Learn more about F# at http://fsharp.org

module main

open System
open OpenQA.Selenium
open canopy
open reporters

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    chromeDir <- "c:\\chromedriver\\"
    start Chrome
    
    url "http://lefthandedgoat.github.io/canopy/testpages/"

    quit()

    0 // return an integer exit code
