using System;

public class IdInfo
{
    public int IdNumber { get; set; }

    public IdInfo(int idNumber)
    {
        IdNumber = idNumber;
    }
}

public class Person
{
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public string Name { get; set; }
    public IdInfo IdInfo { get; set; }

    public Person(int age, DateTime birthDate, string name, IdInfo idInfo)
    {
        Age = age;
        BirthDate = birthDate;
        Name = name;
        IdInfo = idInfo;
    }

    // Shallow Copy
    public Person ShallowCopy()
    {
        return (Person)this.MemberwiseClone();
    }

    // Deep Copy
    public Person DeepCopy()
    {
        Person clone = (Person)this.MemberwiseClone();
        clone.IdInfo = new IdInfo(this.IdInfo.IdNumber);
        clone.Name = String.Copy(this.Name);
        return clone;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        // Original person
        Person originalPerson = new Person(30, DateTime.Now, "John Doe", new IdInfo(12345));

        // Perform shallow copy
        Person shallowCopyPerson = originalPerson.ShallowCopy();

        // Perform deep copy
        Person deepCopyPerson = originalPerson.DeepCopy();

        // Modify the shallow copy's IdInfo and name
        shallowCopyPerson.IdInfo.IdNumber = 54321;
        shallowCopyPerson.Name = "Jane Doe";
        shallowCopyPerson.Age = 40;



        // Modify the deep copy's IdInfo and name
        deepCopyPerson.IdInfo.IdNumber = 98765;
        deepCopyPerson.Name = "Jack Doe";
        shallowCopyPerson.Age = 35;


        // Display results
        Console.WriteLine("Original Person:");
        Console.WriteLine($"Name: {originalPerson.Name},  - ID: {originalPerson.IdInfo.IdNumber} , -Age: {originalPerson.Age} , -Birthday: {originalPerson.BirthDate}");

        Console.WriteLine("\nShallow Copy Person:");
        Console.WriteLine($"Name: {shallowCopyPerson.Name},  - ID: {shallowCopyPerson.IdInfo.IdNumber} , -Age: {shallowCopyPerson.Age} , -Birthday: {shallowCopyPerson.BirthDate}");

        Console.WriteLine("\nDeep Copy Person:");
        Console.WriteLine($"Name: {deepCopyPerson.Name},  - ID: {deepCopyPerson.IdInfo.IdNumber} , -Age: {deepCopyPerson.Age} , -Birthday: {deepCopyPerson.BirthDate}");

        Console.ReadKey();
    }
}
