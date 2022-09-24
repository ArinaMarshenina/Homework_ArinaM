Console.WriteLine("Введи трехзначное число ");
int MyNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(MyNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);