using NUnit.Framework;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace Logicals.ReadExcel
{ 
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Birth { get; set; }
}

class ReadJson
{
    [Test]
    public void ReadJsons()
    {
        Person person = new Person { Name = "Rahul", Age = 30, Birth = 1996 };

        // Serialization
        string json = JsonSerializer.Serialize(person);
        File.WriteAllText("E:\\Study_Projects\\person.json", json);

        // Deserialization
        string json2 = File.ReadAllText("E:\\Study_Projects\\person.json");
        Person de = JsonSerializer.Deserialize<Person>(json2);

        Console.WriteLine($"Name: {de.Name}, Age: {de.Age}, Birth: {de.Birth}");

          
    }
}

}