// using System.Reflection;

// namespace AttributesAndReflectionsLesson
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Person.SayHi();
//             MemberInfo info = typeof(Animal);
//             object[] attributes = info.GetCustomAttributes(true);

//             foreach (var item in attributes)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     };

//     class Person
//     {
//         [Obsolete(
//             message: "This method is not going to be included in the future versions",
//             error: false
//         )]
//         public static void SayHi()
//         {
//             Console.WriteLine("Hi");
//         }

//         public static void SayHello()
//         {
//             Console.WriteLine("Hello");
//         }
//     }

//     // Custom Attributes and Reflections

//     [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
//     public class Developer(string devName, bool isReviewed, string message) : System.Attribute
//     {
//         public string DevName { get; set; } = devName ?? "Unknown";
//         public bool IsReviewed { get; set; } = isReviewed;

//         public string Message { get; set; } = message ?? "Unknown";
//     }

//     [Developer("Dave", true, "This must be finished by Friday")]
//     [Obsolete]
//     class Animal
//     {
//         public static void Greet()
//         {
//             Console.WriteLine("It says hi");
//         }
//     }
// }
