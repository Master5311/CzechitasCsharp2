namespace L08_Abstractions_Interfaces.Creatures
{
    public class Princess : FairytaleCreature
    {
        public override void WriteMyHobbies()
        {
            base.WriteMyHobbies();
            Console.WriteLine("singing in the garden");
        }
    }
}
