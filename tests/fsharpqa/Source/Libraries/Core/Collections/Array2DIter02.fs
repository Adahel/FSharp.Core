// #Regression #Libraries #Collections 
// Regression for FSHARP1.0: 5919
// bug in array2D functions would cause iteri to blow up

module M

let a = Array2D.createBased 1 5 10 10 0.0
a |> Array2D.iteri (fun i j x -> printf "%f" x) 

exit 0
