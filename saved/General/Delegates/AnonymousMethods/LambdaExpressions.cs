// namespace LambdaExpressions
// {
//     delegate void DisplayMessage();
//     delegate int Multiply(int n);

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Multiply multiplyWithLambda = (n) => n * 3;
//             DisplayMessage displayMessageWithLambda = () =>
//             {
//                 Console.WriteLine("Message is displayed");
//             };

//             int res = multiplyWithLambda(5);

//             Multiply multiply = delegate(int n)
//             {
//                 if (n % 2 == 0)
//                 {
//                     return n * 3;
//                 }

//                 return n * 2;
//             };

//             DisplayMessage displayMessage = delegate
//             {
//                 Console.WriteLine("HI FROM ANON METHOD");
//             };
//         }
//     }
// }
