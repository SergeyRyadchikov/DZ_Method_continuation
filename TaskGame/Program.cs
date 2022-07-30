Console.WriteLine("Добро подаловать в игру 'Камень, Ножницы, Бумага'!");
Console.Write("1 - камень" + "\r\n" + "2 - ножницы" + "\r\n" + "3 - бумага" + "\r\n");
int us1 = 0;
int us2 = 0;
int round = 3;
Random rnd = new Random();

for (int count = 0; count < round; count++)
{
    Console.WriteLine("Выберете свой вариант");
    int user1 = Convert.ToInt32(Console.ReadLine());
    int user2 = rnd.Next (1, 4);
    Console.WriteLine(user2);   
    if (user1 == user2) 
    {
        us1++; 
        us2++;
    }
    else if (user1 == 1 && user2 == 2 || user1 == 2 && user2 == 3 || user1 == 3 && user2 == 1) us1++;
    else us2++;
    
}
Console.WriteLine();
if (us1 == us2) Console.WriteLine("Вы: " + us1 + "\r\n" + "Противник: " + us2 + "\r\n" + "Победила дружба!");
else if (us1 < us2) Console.WriteLine("Вы: " + us1 + "\r\n" + "Противник: " + us2 + "\r\n" + "Вы проиграли!");
else Console.WriteLine("Вы: " + us1 + "\r\n" + "Противник: " + us2 + "\r\n" + "Поздравляем! Вы победили!");
