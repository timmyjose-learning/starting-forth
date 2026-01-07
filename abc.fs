\ (a + b) * c -> a b + c * OR c a b + *
\ The second form is more amenable to word definitions since
\ all the operators are clustered together, and so the arguments can be elided 
\ in the definition, and supplied at the time of word invocation

( expects c a b on the stack )
: solution  + * ;