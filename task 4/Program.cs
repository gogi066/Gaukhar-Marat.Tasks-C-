//ex1
//int[] numbers = { 3, 7, 2, 9, 5, 1 };
//int r = 0;
//foreach (var number in numbers)
//{
//    r+= number;
//}
//Console.WriteLine(r);

//ex2.1
//int[] temps = { 12, -3, 45, 0, 28, -10, 33 };
//Array.Sort(temps);
//Console.WriteLine("Min = " + Math.Min(temps[0], temps[temps.Length - 1]));
//Console.WriteLine("Max = " + Math.Max(temps[0], temps[temps.Length - 1]));
//ex2.2
//int[] temps = { 12, -3, 45, 0, 28, -10, 33 };
//int min = temps[0];
//int max = temps[0];
//foreach (var temp in temps)
//{
//    if (temp < min)
//    {
//        min = temp;
//    }
//    if (temp > max)
//    {
//        max = temp;
//    }
//}
//Console.WriteLine("Min = " + min);
//Console.WriteLine("Max = " + max);

//ex3.1
//string[] words = { "apple", "banana", "cherry", "date" };
//for (int i = 0; i < words.Length/2; i++)
//{
//    string temp = words[i];
//    words[i] = words[words.Length - 1 - i];
//    words[words.Length - 1 - i] = temp;
//}
//Console.WriteLine(string.Join(", ", words));

//ex3.2
//string[] words = { "apple", "banana", "cherry", "date" };
//Array.Reverse(words);
//Console.WriteLine(string.Join(", ", words));

//ex4
//int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };
//int evenCount = 0;
//int oddCount = 0;
//foreach (var number in data)
//{
//    if (number % 2 == 0)
//    {
//        evenCount++;
//    }
//    else
//    {
//        oddCount++;
//    }
//}
//Console.WriteLine("Even = " + evenCount);
//Console.WriteLine("Odd = " + oddCount);

//ex5
//int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };

//for (int i = 0; i < raw.Length; i++)
//{
//    bool isDuplicate = false;

//    for (int j = 0; j < i; j++)
//    {
//        if (raw[i] == raw[j])
//        {
//            isDuplicate = true;
//            break;
//        }
//    }

//    if (!isDuplicate)
//        Console.Write(raw[i] + " ");
//}

//ex6
//int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//int k = 3;

//int[] result = RotateLeft(arr, k);

//foreach (int x in result)
//    Console.Write(x + " ");

//static int[] RotateLeft(int[] arr, int k)
//{
//    int n = arr.Length;
//    int[] res = new int[n];

//    for (int i = 0; i < n; i++)
//    {
//        res[i] = arr[(i + k) % n];
//    }

//    return res;
//}
