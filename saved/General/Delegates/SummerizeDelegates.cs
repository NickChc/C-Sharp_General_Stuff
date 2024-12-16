// // Predicate delegate is the same as Action and Func delegates. But it must take one input parameter and return a boolean value


// namespace SummerizeDelegates
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string name = "Nika Chichua";

//             // // Func
//             // Func<string, string> convertToUpperCase = UpperCaseString;
//             // Console.WriteLine("\nUsing Func");
//             // Console.WriteLine(convertToUpperCase(name));

//             // // Anonymous Method
//             // Func<string, string> anonymousMethod = delegate(string name)
//             // {
//             //     return name.ToUpper();
//             // };
//             // Console.WriteLine("\nUsing Anonymous Method");
//             // Console.WriteLine(anonymousMethod(name));

//             // // Lambda
//             // Func<string, string> lambdaMethod = (string name) => name.ToUpper();
//             // Console.WriteLine("\nUsing Lambda Expression");
//             // Console.WriteLine(lambdaMethod(name));

//             // void - Action, Anonymous method with Action and Lambda expression

//             // Action
//             Action<string> displayMessage = DisplayMessage;
//             Console.WriteLine("Using Action delegate");
//             displayMessage(name);

//             // Anonymous method and Action
//             Action<string> displayMessageAnonymous = delegate(string name)
//             {
//                 Console.WriteLine($"Hello from the anonymous method Mr. {name}");
//             };
//             Console.WriteLine("Using Action with anonymous method");
//             displayMessageAnonymous(name);

//             // Lambda expression
//             Action<string> displayMessageLambda = (string name) =>
//             {
//                 Console.WriteLine($"Displaying name with lambda - {name}");
//             };
//             Console.WriteLine("Using lambda expression");
//             displayMessageLambda(name);
//         }

//         public static string UpperCaseString(string value)
//         {
//             return value.ToUpper();
//         }

//         public static void DisplayMessage(string name)
//         {
//             Console.WriteLine($"Hi, how are you? {name}");
//         }
//     }
// }
