
using Try;
Creditcard card=new Creditcard();
while (true)
{
    try
    {
        Console.WriteLine("Введите номер карты:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите ФИО держателя карты:");
        string fio = Console.ReadLine();
        Console.WriteLine("Введите дату действия карты:");
        string date = Console.ReadLine();
        Console.WriteLine("Введите cvc карты:");
        int cvc = int.Parse(Console.ReadLine());

        card.Creditcard_set(number, fio, date, cvc);
        break;
    }
    catch
    {
        Console.WriteLine("Где то накосячил вводи снова!");
    }
}
while (true)
{
    Console.WriteLine("Если хотите поменять номер карты введите 1");
    int t = int.Parse(Console.ReadLine());





    if (t==1)
    {
        Console.WriteLine("Введите новый номер: ");
        card.Replace_card_number(int.Parse(Console.ReadLine()));
    }
}