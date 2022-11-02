
using Try;

Console.WriteLine("Введите номер карты:");
int number=int.Parse(Console.ReadLine());
Console.WriteLine("Введите ФИО держателя карты:");
string fio = Console.ReadLine();
Console.WriteLine("Введите дату действия карты:");
string date = Console.ReadLine();
Console.WriteLine("Введите cvc карты:");
int cvc = int.Parse(Console.ReadLine());

Creditcard card = new Creditcard(number,fio,date,cvc);