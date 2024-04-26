classDiagram
    class Animal {
        <<abstract>>
        +Sound(): string
    }
    class Dog {
        +Sound(): string
    }
    class Cat {
        +Sound(): string
    }
    class Bat {
        +Sound(): string
    }
    class Bee {
        +Sound(): string
    }
    class IMammal {
        +NumberOfNipples: int
    }
    class ICanFly {
        +NumberOfWings: int
    }

    Animal <|-- Dog
    Animal <|-- Cat
    Animal <|-- Bat
    Animal <|-- Bee
    IMammal <|.. Dog
    IMammal <|.. Cat
    IMammal <|.. Bat
    ICanFly <|.. Bat
    ICanFly <|.. Bee
