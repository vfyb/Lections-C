// // No input no input
// void Method1()
// {
//     Console.WriteLine("Any text");
// }
// Method1();

// // Have input no output
// void Method2(string msg, int count)
// {
//     Console.WriteLine($"msg - {count}");
// }
// Method2("Any text", 4);
// Method2(count: 4, msg: "Any text");

// // No input have output
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year - Method3();
// Console.WriteLine(year);

// //Have input and output
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while ( i < count )
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Any");
// Console.WriteLine(res);