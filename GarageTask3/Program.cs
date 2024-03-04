#region Task-1
//Console.Write("Word : ");
//string word = Console.ReadLine();
//Console.Write("Letter : ");
//char letter = char.Parse(Console.ReadLine());


//int FindCharIndex(string word, char letter)
//{
//    for (int i = 0; i < word.Length; i++)
//    {
//        if (word[i] == letter)
//        {
//            return i;
//        }
//    }
//    return -1;
//}
//Console.WriteLine($"Index : {FindCharIndex(word,letter) }");
#endregion
#region Task-2
//Console.Write("Fennlerin sayi : ");
//int size = int.Parse(Console.ReadLine());

//int[] points = new int[size];

//for (int i = 0; i < size; i++)
//{
//    Console.WriteLine($"Qiymet daxil edin" +
//        $".({i + 1})");
//    points[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("-----------------------------------------");

//double CalcAvg(int[] arr)
//{
//    int sum = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        sum += arr[i];
//    }

//    return sum / arr.Length;
//}
//double ortalama = CalcAvg(points);
//if(ortalama > 60)
//    Console.WriteLine($"mezun oldunuz, ortalama baliniz--->{ortalama}");
//else
//    Console.WriteLine($"mezun ola bilmediniz--->{ortalama}");

#endregion
#region Task-3
//bool IsPrime(int number)
//{
//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}

//Console.Write("Eded daxil edin : ");
//int number = int.Parse(Console.ReadLine());
//if (number < 2)
//{
//    Console.WriteLine("Eded ne sade ne murekkebdir");
//    return;
//}
//string result = IsPrime(number) ? "Eded sadedir." : "Eded murekkebdir.";
//Console.WriteLine(result);

#endregion
#region Task-4
//Console.Write("ilk eded : ");
//double number1 = double.Parse(Console.ReadLine());
//Console.Write("ikinci eded : ");
//double number2 = double.Parse(Console.ReadLine());
//Console.Write("ucuncu eded : ");
//double number3 = double.Parse(Console.ReadLine());
//double FindMax(double number1 = 4 , double number2 = 3 , double number3 =5)
//{
//    double maxNumber = number1;
//    if(number2 > number1)
//    {
//        maxNumber = number2;
//    }
//    if(number3 > maxNumber)
//    {
//        maxNumber = number3;
//    }
//    return maxNumber;
//}

//Console.WriteLine($"En boyuk eded : {FindMax(number1,number2,number3)}");

#endregion
