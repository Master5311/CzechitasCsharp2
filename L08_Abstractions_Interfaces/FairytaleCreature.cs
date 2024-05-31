namespace L08_Abstractions_Interfaces
{
    public abstract class FairytaleCreature
    {
        public virtual void WriteMyHobbies()
        {
            Console.WriteLine("MY HOBBIES:");
            Console.WriteLine("catching dwarves");           // every fairytale creature likes to catch dwarves (including the dwarves themselves)
        }
    }
}
