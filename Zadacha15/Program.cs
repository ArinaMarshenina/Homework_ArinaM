Console.Write("Введите цифру, обозначающую день недели ");
int NumberOfDay = Convert.ToInt32(Console.ReadLine());

void TheDayOfTheWeek (int NumberOfDay) 
{
  if (NumberOfDay == 6 ^ NumberOfDay == 7) 
  {
  Console.WriteLine("Этот день выходной");
  }
  else if (NumberOfDay < 1 ^ NumberOfDay > 7) 
  {
    Console.WriteLine("Это не день недели");
  } 
  else Console.WriteLine("Этот день не выходной");
}
TheDayOfTheWeek(NumberOfDay);