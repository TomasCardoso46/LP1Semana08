namespace AnimalKingdom
{
    public class Bat : Animal
    {
        public int NumberOfNipples { get; } = 2;
        public override string Sound()
        {
            return base.Sound() + "Screech!";
        }
    }
}
