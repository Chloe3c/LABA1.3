try
{
    Console.Write("Введите номер квартиры: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine($"Этаж={(x - 1)/4+1}");
    Console.WriteLine($"Квартира {(x-1)%4+1} на этаже");


}
catch
{
    Console.WriteLine("Введите правильно!");
}