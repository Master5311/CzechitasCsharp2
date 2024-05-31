namespace L08_Abstractions_Interfaces.Creatures
{
    public class Witch : FairytaleCreature
    {
        public override void WriteMyHobbies()
        {
            base.WriteMyHobbies();
            Console.WriteLine("doing magic");
        }
    }
}
