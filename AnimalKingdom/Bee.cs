namespace AnimalKingdom
{
    public class Bee : Animal
    {
        public int NumberOfWings { get; } = 2;
        public override string Sound()
        {
            return base.Sound() + "Buzz!";
        }
    }
}
