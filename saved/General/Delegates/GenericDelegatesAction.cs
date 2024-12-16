// Same as Func, but doesn't return a value
// namespace GenericDelegatesAction
// {
// class Program
// {
// static void Main(string[] args)
// {
// Action<int> action1 = DisplayInfo;
// action1(16);
//
// Action action2 = DisplayInfo;
// action2();
// }
//
// public static void DisplayInfo()
// {
// Console.WriteLine("With no params");
// }
//
// public static void DisplayInfo(int x)
// {
// Console.WriteLine(x);
// }
// }
// }
//
