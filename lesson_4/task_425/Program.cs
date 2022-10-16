int degree(int number, int deg){
    int result = number;
    for (int i = 1; i < deg; i++){
        result = result*number;
    }
    return result;
}

Console.WriteLine("введите число");
string numberInput = Console.ReadLine();
int numberInputInt = int.Parse(numberInput);
Console.WriteLine("введите степень");
string degInput = Console.ReadLine();
int degInputInt = int.Parse(degInput);
Console.Write(degree(numberInputInt, degInputInt));
