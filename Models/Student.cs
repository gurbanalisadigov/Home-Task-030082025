
using System.Drawing;
using System.Xml.Linq;

public class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public double Point;
    public bool IsGraduated;

    public Student(string Name, string Surname, string Group, double Point)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Group = Group;
        this.Point = Point;
        this.IsGraduated = true;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"name: {Name}, surname: {Surname}, group: {Group}, point: {Point}, isgraduated: {IsGraduated}");
    }
    public void CheckGraduation()
    {
        if (IsGraduated)
            Console.WriteLine("Telebe Mezun Olub");
        else
            Console.WriteLine("Telebe Mezun Olmayib");
    }
    public void GetDiplomDegree()
    {

        if (Point < 65)
            Console.WriteLine("Diplom Yoxdur");
        else if (Point < 80)
            Console.WriteLine("Adi Diplom");
        else if (Point < 90)
            Console.WriteLine("Sheref Diplomu");
        else
            Console.WriteLine("Yuksek Sheref Diplomu");

    }

}












