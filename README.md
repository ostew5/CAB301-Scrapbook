# CAB301 Scrapbook

## Tutorial 1: Introduction to Algorithms and Complexity

### Part A: Tutorial Questions

1. What is an algorithm and what are its characteristics? Are algorithms laugage-specific?
1. What is pseudocode?
1. Describe the standard algorithm for finding the decimal representation of a positive binary number.
	
	a. in English

	b. in the pseudocode defined in Lecture 1

1. Consider the following algorithm for finding the distance between the two closest elements in an array of numbers

```
ALGORITHM MinDistance(A[0..n - 1])
//Input: Array A[0..n - 1] of numbers
//Output: Minimum distance between two of its elements
dmin <- inf
    for i <- 0 to n - 1 do
        for j <- 0 to n - 1 do
            if i != j and |A[i] - A[j]| < dmin
            dmin <- |A[i] - A[j]|
return dmin
```

Make as many improvements as you can in this algorithmic solution to the problem.

### Part B: Programming Tasks

5. Implement the algorithm for finding the distance between two closest elements in an array of numbers shown in Question 4 and test the implementation.
1. A sorted list is a list whose items are kept sorted. For example, `S1 = [1, 3, 6, 8, 9]`
is a sorted list, while `S2 = [3, 1, 6, 8, 9]` is not. There are three primary operations
defined on a sorted list: insert, delete, and search. When inserting an item into a
sorted list we must insert the item at an appropriate position such that the items in
the list are still kept sorted after the insertion. Similarly, when removing an item
out of a sorted list we must make sure that the items in the list are kept sorted.
Given an item, the search operation is to find the position of the item in the sorted
list. If the given item is not present in the list, then a negative number, let’s say -1,
is returned. Since a sorted list is a container, it has attributes that most containers
have, such as capacity (the maximal number of elements that can be stored in the
linked list and count (number of items currently stored in the sorted list). The
ADT should also provide the following operations: test if a sorted list is empty,
test if a sorted list if full, clear all items in a sorted list.
Develop a reusable data structure in C# to store and manipulate a sorted list of
integers. Write an application program to test all the operations defined in the data
structure.
