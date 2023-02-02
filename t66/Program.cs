    // task 66. Задайте числа m,n. Напишите программу, которая выведет сумму натуральных чисел в промежутке от m до n. 

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());  
    
    int SumNumbers(int m, int n)
{
  return n!=m ? SumNumbers(m, n-1) + n : n; 
 
}
  Console.WriteLine(SumNumbers(m,n));
