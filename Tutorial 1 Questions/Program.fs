// 5. Implement the algorithm for finding the distance between two closest elements in an array of numbers shown in Question 4 and test the implementation

(*
4.
ALGORITHM MinDistance(A[0..n - 1])
//Input: Array A[0..n - 1] of numbers
//Output: Minimum distance between two of its elements
dmin <- inf
    for i <- 0 to n - 1 do
        for j <- 0 to n - 1 do
            if i != j and |A[i] - A[j]| < dmin
            dmin <- |A[i] - A[j]|
return dmin
*)