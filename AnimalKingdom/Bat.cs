namespace AnimalKingdom
{
    public class Bat : Animal, ICanFly, IMammal
    {
        public int NumberOfNipples { get; } = 2;
        public int NumberOfWings { get; } = 2;
        public override string Sound()
        {
            return base.Sound() + "Screech!";
        }
    }
}
