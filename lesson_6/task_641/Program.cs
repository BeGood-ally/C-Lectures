using System;
using System.Text.RegularExpressions;

int amountOfAboveZero() {
    List <int> abovezero = new List <int>();
    Regex regex = new Regex("(-?[0-9]+)");
    while (true){ 
        Console.WriteLine("введите число или 'q' для завершения");
        string ?num = Console.ReadLine();
        if(regex.IsMatch(num) == true){
            int sign = Math.Sign(int.Parse(num)); 
            abovezero.Add(sign);
        }
        else if(num == "q"){
            break;
        }
        else {
            Console.WriteLine("вы ввели не число введите число");
        }
    }
    int count = 0;
    foreach (int plus in abovezero){ 
        if(plus == 1) count++;
    }
    return count;
}

int rez = amountOfAboveZero();
Console.WriteLine($"количество чисел больше нуля из введенных вами равно: {rez}");