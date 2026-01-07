\ ab + c -> c a b * +

: 2b1  ( c b a -- result )   * + ;

\ (a - 4b) / 6 + c -> c a b 4 * - 6 / +

: 2b2  ( c a b -- result  )   4 * - 6 / + ;

\ a / 8b -> a b 8 * / 

: 2b3   ( a b -- result ) 8 * / ;

\ 0.5ab / 100 -> a b * 200 / 

: 2b4   ( a b -- result ) * 200 / ;

\ a (2a + 3) -> a a 2 * 3 + *

: 2b5  ( a a -- result ) 2 * 3 + * ;

\ (a - b) / c -> a b - c /
\ So, not really possible to have a "point-free" form without stack manipulation operators