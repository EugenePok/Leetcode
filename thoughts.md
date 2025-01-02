::: mermaid
flowchart TD;
option[2,7,8,3]

    9 --> |Pick 2| 7
    9 --> |Not Pick 2| a9

    7 --> |Pick 7| 0
    7 --> |Not Pick 7| a7

    a9 --> |Pick 7| 2
    a9 --> |Not Pick 7| b9

    b9 --> |Not Pick 11| c9
    c9 --> |Not Pick 15| d9

:::
