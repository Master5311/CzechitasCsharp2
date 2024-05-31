namespace L08_Abstractions_Interfaces.Creatures
{
    public class Knight : FairytaleCreature
    {
        public override void WriteMyHobbies()
        {
            base.WriteMyHobbies();
            Console.WriteLine("cutting dragon heads");
        }
    }
}
