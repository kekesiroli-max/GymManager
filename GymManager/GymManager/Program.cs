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

            Membership membership1 = new Membership(mem1, 5000, 2);
            Membership membership2 = new Membership(mem2, 5000, 5);
            membership1.TotalCost();
            membership2.TotalCost();
            membership1.Extend(1);
            membership2.Extend(4);
            membership1.TotalCost();
            membership2.TotalCost();

            Gym gym1 = new Gym("név1");
            Gym gym2 = new Gym("név2");

            Console.WriteLine(gym1.TotalIncome());

            mem1.Describe();

            Console.WriteLine(gym1.BestValue());
        }
    }
}
