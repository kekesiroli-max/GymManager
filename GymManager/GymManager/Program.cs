namespace GymManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member mem1 = new Member("név1", 1, true);
            Member mem2 = new Member("név2", 2, false);
            Member mem3 = new Member("név3", 3, true);

            mem1.CheckIn();
            Console.WriteLine(mem1.Describe());
            Console.WriteLine(mem2.Describe());
            Console.WriteLine(mem3.Describe());
        }
    }
}
