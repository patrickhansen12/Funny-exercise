// Learn more about F# at http://fsharp.org

open System

//beginner example
let list = [1..3..30]

let folder state value = 
    if value % 2 = 0 then
        state + value
    else
        state

let initalState = 0

List.fold folder initalState list



// factorial example
let list1 = [1..1..6] //here use n as last value

let folder1 state value = 
    state * value

let initalState1 = 1

List.fold folder1 initalState1 list1


//exits function
let exists condition elements = 
    elements
    |> List.map condition
    |> List.fold (||) false


let contains x xs = exists (fun y -> y = x) xs

contains 6 [1..5]


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    if contains 69 [1..2..1000] then
        printf "
        NNNNNNNN        NNNNNNNN  iiii                                          
        N:::::::N       N::::::N i::::i                                         
        N::::::::N      N::::::N  iiii                                          
        N:::::::::N     N::::::N                                                
        N::::::::::N    N::::::Niiiiiii     cccccccccccccccc    eeeeeeeeeeee    
        N:::::::::::N   N::::::Ni:::::i   cc:::::::::::::::c  ee::::::::::::ee  
        N:::::::N::::N  N::::::N i::::i  c:::::::::::::::::c e::::::eeeee:::::ee
        N::::::N N::::N N::::::N i::::i c:::::::cccccc:::::ce::::::e     e:::::e
        N::::::N  N::::N:::::::N i::::i c::::::c     ccccccce:::::::eeeee::::::e
        N::::::N   N:::::::::::N i::::i c:::::c             e:::::::::::::::::e 
        N::::::N    N::::::::::N i::::i c:::::c             e::::::eeeeeeeeeee  
        N::::::N     N:::::::::N i::::i c::::::c     ccccccce:::::::e           
        N::::::N      N::::::::Ni::::::ic:::::::cccccc:::::ce::::::::e          
        N::::::N       N:::::::Ni::::::i c:::::::::::::::::c e::::::::eeeeeeee  
        N::::::N        N::::::Ni::::::i  cc:::::::::::::::c  ee:::::::::::::e  
        NNNNNNNN         NNNNNNNiiiiiiii    cccccccccccccccc    eeeeeeeeeeeeee  "


    0 // return an integer exit code
