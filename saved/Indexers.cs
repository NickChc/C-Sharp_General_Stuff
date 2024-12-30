// namespace Indexers
// {
//     // Those are pretty useless IMO :D
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Animal animal = new();

//             animal[0] = "dog";
//             animal[1] = "Tiger";
//             animal[2] = "Horse";
//             animal[12] = "Test";

//             Console.WriteLine(animal[12]);
//         }
//     };

//     class Animal
//     {
//         private string[] _name = new string[100];

//         private string[] _surname = new string[10];

//         public string this[int index]
//         {
//             get => _name[index];
//             set => _name[index] = value;
//         }
//     }
// }
