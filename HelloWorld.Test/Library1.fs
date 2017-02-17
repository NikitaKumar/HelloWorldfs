//namespace HelloWorld.Test
//
//type Class1() = 
//    member this.X = "F#"
module HelloWorld.Tests.Hello

open HelloWorld.Core.Hello
open NUnit.Framework
open FsUnit

[<Test>]
let shouldSayHello () = Assert.AreEqual("Hello World!", SayHello "World")