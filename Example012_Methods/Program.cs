  //1 Вид
  void Method1()
  {
      Console.WriteLine("Автор...");
  }
  Method1();
  //Метод ничего не возращает



  
 // 2 Вид 
  void Method2(string msg)
  {
      Console.WriteLine(msg);
  }
  void Method21(string msg, int count)
  {
      int i = 0;
      while(i < count)
      {
          Console.WriteLine(msg);
          i++;
      }
  }
  Method21("Текс", 4);
 // метод принимает агрументы
 // Вид 3
  int Method3()
  {
      return DateTime.Now.Year;
  }
  int year = Method3();
  Console.WriteLine(year);



 // 4 Вид
 string Method4(int count, string c)
 {
     int i = 0;
     string result = String.Empty; 
     //String.Emply значит пустая строка все равно что ""
     while(i < count)
     {
         result = result + c;
         i++;
     }
     return result;
 }
 string res = Method4(10, "z");
 Console.WriteLine(res);
 // Принимает аргументы и возращает



// Цикл for, цикл в цикле
for(int i = 2; i < 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");  
    }
    Console.WriteLine();
}
