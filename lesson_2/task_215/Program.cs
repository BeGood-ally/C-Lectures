string a = Console.ReadLine();
if (a.Length == 1){
    try {
        int ai = int.Parse(a);
        if (ai <= 5 && ai >= 1){
            Console.WriteLine("нет");
        }
        else if (ai == 7 || ai == 6){
            Console.WriteLine("да");
        }
        else {
            Console.WriteLine("число меньше 1, либо больше 7");
        }
    }
    catch (System.FormatException){
        Console.WriteLine("введенный символ не является числом");
    }
    }
else {
    Console.WriteLine("вы ввели более одного символа либо не ввели ничего");
}