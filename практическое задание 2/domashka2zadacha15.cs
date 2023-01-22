//Задача 15: Напишите программу, 
//которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Задача 15. Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(выходной день) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine(" не день недели");
  }
  else Console.WriteLine("(не выходной день) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);