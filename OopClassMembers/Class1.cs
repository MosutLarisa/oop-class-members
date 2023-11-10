namespace OopClassMembers;

internal class Persons
{

    public string FirstName = "Jhon";

    public string LastName = "Doe";

    // readonly field can be modified from the initialization expression (#1)
    public readonly string CNP = "1234";

    public static int PopulationCount = 0;

    public const int MaxLifespanYears = 60 * 2 + 10;

    //this is  a constructor

    public Persons(string cnp)
    {
        // readonly field can be modified from the constructor (#2)
        CNP = cnp;
    }

    public void PrintPerson()
    {

    }

    public static void PrintPopulationCount()
    {
        
    }







}

