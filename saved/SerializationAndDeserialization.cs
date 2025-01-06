// using System.Runtime.Serialization;
// using System.Text.Json.Serialization;
// using System.Xml.Serialization;

// namespace SerializationAndDeserialization
// {
//     // Serialization is the process of converting an object to stream of bytes to store it or transmit it to a database or a file. It's man purpose is to save the state of an object in order to be able to recreate it when needed.

//     // Deserialization is the opposite of this proccess.
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string xmlText = default!;

//             List<Dev> devs = [new() { Name = "Dave", Age = 32 }];

//             Console.WriteLine(devs[0].DevId);

//             XmlSerializer xmlSerializer = new(typeof(List<Dev>));

//             using StringWriter sw = new();
//             xmlSerializer.Serialize(sw, devs);
//             xmlText = sw.ToString();

//             Console.WriteLine(xmlText);

//             XmlSerializer xmlReader = new(typeof(List<Dev>));
//             using StringReader sr = new(xmlText);
//             List<Dev> tempList = (List<Dev>)xmlReader.Deserialize(sr)!;

//             foreach (Dev dev in tempList)
//             {
//                 Console.WriteLine(dev.Name);
//                 Console.WriteLine(dev.Age);
//                 Console.WriteLine(dev.DevId);
//             }
//         }
//     };

//     public class Dev
//     {
//         [XmlAttribute("Id")]
//         public Guid DevId { get; set; } = Guid.NewGuid();
//         public string Name { get; set; } = "Unknown";

//         [XmlIgnore]
//         public int Age { get; set; } = 0;
//     }
// }
