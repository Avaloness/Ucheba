//Задача 13: Напишите программу, 
//которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.Write("задача 13. Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей нет");
}