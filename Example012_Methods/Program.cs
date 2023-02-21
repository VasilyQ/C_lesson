//   // ========= 1 Вид
//   void Method1()
//   {
//       Console.WriteLine("Автор...");
//   }
//   Method1();
//   //Метод ничего не возращает




//  // ========= 2 Вид 
//   void Method2(string msg)
//   {
//       Console.WriteLine(msg);
//   }
//   void Method21(string msg, int count)
//   {
//       int i = 0;
//       while(i < count)
//       {
//           Console.WriteLine(msg);
//           i++;
//       }
//   }
//   Method21("Текс", 4);
//  // метод принимает агрументы


//  // ========= Вид 3
//   int Method3()
//   {
//       return DateTime.Now.Year;
//   }
//   int year = Method3();
//   Console.WriteLine(year);



//  // ========= 4 Вид
//  string Method4(int count, string c)
//  {
//      int i = 0;
//      string result = String.Empty; 
//      //String.Emply значит пустая строка все равно что ""
//      while(i < count)
//      {
//          result = result + c;
//          i++;
//      }
//      return result;
//  }
//  string res = Method4(10, "z");
//  Console.WriteLine(res);
//  // Принимает аргументы и возращает



// // ========= Цикл for, цикл в цикле
// for(int i = 2; i < 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");  
//     }
//     Console.WriteLine();
// }


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replase(string text, char OldValue, char NewValue)
// {
//     string result = String.Empty;

//     int Length = text.Length;
//     for(int i = 0; i < Length; i++)
//     {
//         if(text[i] == OldValue) result = result + $"{NewValue}";
//         else result = result + $"{text[i]}";
//     }
    
//     return result;
// }

// string newText = Replase(text, ' ', '|');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replase(newText, 'к', 'К');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replase(newText, 'С', 'с');
// Console.WriteLine(newText);


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
         int minPosition = i;

        for(int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);