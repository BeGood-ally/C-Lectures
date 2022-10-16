int summ(string num){
    int number = 0;
    int summa = 0;
    for (int i = 0; i < num.Length; i++){
        number = num[i] - '0';
        summa = summa + number;
    }
    return summa; 
}

Console.WriteLine("введите число");
string numInp = Console.ReadLine();
Console.WriteLine(summ(numInp));
