open System
open System.Collections.Generic

let salaries = [ 75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0 ]

printfn "Original salaries: %A" salaries


let highIncomeSalaries = salaries |> List.filter (fun salary -> salary > 100000.0)
printfn "Original salaries before high-income filter: %A" salaries
printfn "High-income salaries: %A" highIncomeSalaries


let calculateTax salary =
    match salary with
    | s when s <= 49020.0 -> s * 0.15
    | s when s <= 98040.0 -> s * 0.205
    | s when s <= 151978.0 -> s * 0.26
    | s when s <= 216511.0 -> s * 0.29
    | _ -> salary * 0.33


let printSalaryAndTax salary =
    let tax = calculateTax salary
    printfn "Salary = %.2f, Tax = %.2f" salary tax

salaries |> List.iter printSalaryAndTax


let updatedSalaries = 
    salaries
    |> List.map (fun salary -> if salary < 49020.0 then salary + 20000.0 else salary)
printfn "Original salaries before updating low-income: %A" salaries
printfn "Updated salaries: %A" updatedSalaries


let sumSalaries =
    salaries
    |> List.filter (fun salary -> salary >= 50000.0 && salary <= 100000.0)
    |> List.reduce (+)
printfn "Original salaries before sum filter: %A" salaries
printfn "Sum of salaries between $50,000 and $100,000: %.2f" sumSalaries


let sumOfMultiplesOfThree n =
    let rec helper current acc =
        if current > n then acc
        else helper (current + 3) (acc + current)
    helper 3 0 


let result = sumOfMultiplesOfThree 27
printfn "Sum of multiples of 3 up to 27 is: %d" result

