using Ellis_PolyPayroll;
using System.Runtime.CompilerServices;

class MainProgram
{
    private static List<IPayable> payables = new List<IPayable>();
    static void Main(string[] args)
    {
        payables.Add(new SalariedEmployee("Adam", "Adams", "111-11-1111", 1000M));
        payables.Add(new SalariedEmployee("Bart", "Bartley", "222-22-2222", 2000M));
        payables.Add(new SalariedEmployee("Collin", "Collins", "333-33-3333", 3000M));

        payables.Add(new HourlyEmployee("Dennis", "Dennings", "444-44-444", 44.44M, 4));
        payables.Add(new HourlyEmployee("Evan", "Evans", "555-55-5555", 55.55M, 5));
        payables.Add(new HourlyEmployee("Frank", "Franklin", "666-66-6666", 66.66M, 66));

        payables.Add(new Invoice("1111", 1, "Hat", 15.99M));
        payables.Add(new Invoice("2222", 2, "Shoes", 20.99M));
        payables.Add(new Invoice("3333", 3, "Piercings", 25.99M));
    }
}    