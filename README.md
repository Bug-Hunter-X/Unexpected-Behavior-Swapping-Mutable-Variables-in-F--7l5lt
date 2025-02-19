# F# Mutable Variable Swapping Bug

This repository demonstrates an interesting quirk in F# when dealing with mutable variables and tuple swapping.  The code highlights unexpected behavior when attempting to swap more than two mutable variables.  The issue stems from the limitations of direct tuple manipulation and the need for more explicit handling when dealing with multiple variables.

## Bug Description

The core problem lies in the way F# handles mutable variables and tuples.  While swapping two variables using references is straightforward, extending this to three or more variables requires a more nuanced approach.  Attempting to directly swap tuple elements beyond two variables leads to compile-time errors.

## Solution

The provided solution offers a generic function (`swapTupleN`) to handle tuple swapping of any size. This utilizes pattern matching and recursion to elegantly address the limitation.