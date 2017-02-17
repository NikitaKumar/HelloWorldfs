namespace HelloWorld.Test
//
//type Class1() = 
//    member this.X = "F#"
//module HelloWorld.Tests.Hello
open NUnit.Framework
open FsUnit
open HelloWorld.Core.Hello
open HelloWorld.Core.Bye
module Hellotest=   
//    open HelloWorld.Core.Bye
    
    [<Test>]
    let shouldSayHello () = Assert.AreEqual("Hello World!", SayHello "World")

//    [<Test>]
//    let shouldSayBye () = Assert.AreEqual("Hello World!", SayBye "World")