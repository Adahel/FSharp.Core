// #Conformance #DeclarationElements #LetBindings #ActivePatterns 
let (|MulThree|_|) inp = if inp % 3 = 0 then Some (inp / 3) else None in

let result = 
    match 27 with
    | MulThree remainder -> remainder
    | _ -> exit 1 in
    
if result <> 9 then exit 1

exit 0






        
    
