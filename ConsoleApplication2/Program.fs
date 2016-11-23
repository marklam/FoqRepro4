open Foq

type IFoo =
    abstract N : int64

module Main =
    [<EntryPoint>]
    let main _ = 
//        let mock1 = Mock<IFoo>().Setup(fun foo -> <@ foo.N @>).Returns(7).Create()
//        printfn "%d" mock1.N

        let mock2 = Mock<IFoo>().Setup(fun foo -> <@ foo.N @>).ReturnsFunc(fun () -> 7L).Create()
        printfn "%d" mock2.N

        0
