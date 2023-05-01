using System;

public class Program
{
    public static void Main()
    {
        int notebooks, pens;

        double priceNotebook, prisePen, money;

        do
        {
            Console.Write("Скiльки зошитiв треба купити: ");
            notebooks = int.Parse(Console.ReadLine());
        } while (notebooks < 0);
        do
        {
            Console.Write("Скiльки ручок треба купити: ");
            pens = int.Parse(Console.ReadLine());
        } while(pens < 0);


        do
        {
            Console.Write("Скiльки коштує один зошит: ");
            priceNotebook = double.Parse(Console.ReadLine());
        } while (priceNotebook < 0);
        do
        {
            Console.Write("Скiльки коштує одна ручка: ");
            prisePen = double.Parse(Console.ReadLine());
        } while (prisePen < 0);


        do
        {
            Console.Write("Скiльки у вас грошей: ");
            money = double.Parse(Console.ReadLine());
        } while (money < 0);



        double priceNotebooks = notebooks * priceNotebook;
        double prisePens = pens * prisePen;
        double prise = priceNotebooks + prisePens;

        if (money > prise)
        {
            double remained = money - prise;
            Console.WriteLine($"Пiсля покупки у вас залишиться {remained} грн.");
        }
        else if (money == prise)
        {
            Console.WriteLine("Пiсля покупки у вас не залишиться жодної гривнi.");
        }
        else
        {
            Console.WriteLine("За наявної кiлькостi грошей ви не зможете здiйснити таку покупку.");
        }
    }
}