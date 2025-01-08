// namespace RefReturnAndRefLocal
// {
//     class Program
//     {
//         static string[] arrayOfNames = ["Claire", "Ella", "Jane", "Dave"];

//         static void Main(string[] args)
//         {
//             int x1 = 3;
//             ref int x2 = ref x1;

//             x2 += 1;

//             // Console.WriteLine(x1);
//             // Console.WriteLine(x2);


//             ref string name = ref ReturnByRef();

//             name = "New Name";

//             Console.WriteLine(arrayOfNames[0]);
//         }

//         public static ref string ReturnByRef()
//         {
//             return ref arrayOfNames[0];
//         }
//     };
// }
