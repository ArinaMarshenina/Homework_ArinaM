Console.Write("Введите число ");
int MyNumber = Convert.ToInt32(Console.ReadLine());
string MyNumberString = Convert.ToString(MyNumber);
if (MyNumberString.Length > 2)
{
  Console.WriteLine("третья цифра этого числа-> " + MyNumberString[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
};