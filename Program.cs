//Console.WriteLine("Exercise 1:");
//Console.WriteLine("Enter first number");
//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter second number");
//int m = Convert.ToInt32(Console.ReadLine());

//if (n > m)
//{
//    Console.WriteLine("first number is greater than the second");
//}
//else if (m > n)
//{
//    Console.WriteLine("second number is greater than the first");
//}
//else
//{
//    Console.WriteLine("numbers are equal");
//}

//Console.WriteLine("Exercise 2:");
//Console.WriteLine("Enter number");
//int n = Convert.ToInt32(Console.ReadLine());

//if (n > 5 && n < 10)
//{
//    Console.WriteLine("The number is greater than 5 and less than 10");
//}
//else
//{
//    Console.WriteLine("Unknown number");
//}

//Console.WriteLine("Exercise 3:");
//Console.WriteLine("Enter number");
//int n = Convert.ToInt32(Console.ReadLine());

//if (n == 5 || n == 10)
//{
//    Console.WriteLine("The number is either 5 or 10");
//}
//else
//{
//    Console.WriteLine("Unknown number");
//}

//Console.WriteLine("Exercise 4:");
//Console.WriteLine("Enter deposit");
//double n = Convert.ToDouble(Console.ReadLine());
//if (n < 100)
//{
//    n = n + (n * 5 / 100);
//    Console.WriteLine(n);
//}
//else if (n >= 100 && n <= 200)
//{
//    n = n + (n * 7 / 100);
//    Console.WriteLine(n);
//}
//else
//{
//    n = n + (n * 10 / 100);
//    Console.WriteLine(n);
//}

//Console.WriteLine("Exercise 5:");
//Console.WriteLine("Enter deposit");
//double n = Convert.ToDouble(Console.ReadLine());
//if (n < 100)
//{
//    n = n + (n * 5 / 100) + 15;
//    Console.WriteLine(n);
//}
//else if (100 <= n && n <= 200)
//{
//    n = n + (n * 7 / 100) + 15;
//    Console.WriteLine(n);
//}
//else
//{
//    n = n + (n * 10 / 100) + 15;
//    Console.WriteLine(n);
//}

//Console.WriteLine("Exercise 6:");
//Console.WriteLine("Choose operation: 1 is +, 2 is -, 3 is *");
//int m = Convert.ToInt32(Console.ReadLine());

//switch (m)
//{
//    case 1:
//        Console.WriteLine("Plus");
//        break;

//    case 2:
//        Console.WriteLine("Minus");
//        break;

//    case 3:
//        Console.WriteLine("Multiplication");
//        break;

//    default:
//        Console.WriteLine("Unknown operation");
//        break;
//}

//Console.WriteLine("Exercise 7:");
//Console.WriteLine("Choose operation: 1 is +, 2 is -, 3 is *");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter first number:");
//int b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter second number:");
//int c = Convert.ToInt32(Console.ReadLine());

//switch (a)
//{
//    case 1:
//        Console.WriteLine(b + c);
//        break;

//    case 2:
//        Console.WriteLine(b - c);
//        break;

//    case 3:
//        Console.WriteLine(b * c);
//        break;

//    default:
//        Console.WriteLine("Unknown operation");
//        break;
//}