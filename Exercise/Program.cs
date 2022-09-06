using DapperDemo.Repositories;

internal class Program
{
    private static void Main(string[] args)
    {
        ISchoolRepository repository = new SchoolRepository();
        
        // sample printing
        var testSchool = repository.GetSchool(1);
        Console.WriteLine(testSchool);

        // TODO: Do this workflow in Main
        // 1. Add new school UV
        // 2. Print id of new school UV
        // 3. Get new school UV using id and print
        // 4. Update school UV's motto
        // 5. GetAllSchools, loop each school and print
        // 6. Delete school UV
        // 7. GetAllSchools, loop each school and print again
    }
}