namespace OopClassMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxiLifespan = Persons.MaxLifespanYears;
            Persons p = new Persons();
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
            Console.WriteLine(p.CNP);

            
            Persons.PopulationCount = 1;

        }
    }
}