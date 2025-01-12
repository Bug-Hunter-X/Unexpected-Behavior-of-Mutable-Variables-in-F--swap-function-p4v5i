# F# Mutable Variable Swap Bug

This repository demonstrates an uncommon bug related to the behavior of mutable variables in F#.  When attempting to swap two mutable variables using a function, the unexpected outcome occurs due to pass-by-reference semantics.

## Bug Description

The `swap` function intends to exchange the values of two mutable variables. However, due to F#'s pass-by-reference for mutable variables, the original variables are directly modified within the function. This leads to both variables having the same value after the swap operation.

## Solution

The solution involves creating copies of the input values within the `swap` function before performing the swap operations. This ensures that the original variables remain unaffected.