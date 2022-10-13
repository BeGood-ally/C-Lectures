string [] coords = {"x","y","z"};
int [] arrAi = new int[3];
int [] arrBi = new int[3];
string? tempSt = "";
int tempIn = 0;
for(int i = 0; i < arrAi.Length; i++){
        Console.WriteLine("введите у первой точки координату " + coords[i]);
        tempSt = Console.ReadLine();
        tempIn = int.Parse(tempSt);
        arrAi[i] = tempIn;
    }
for(int i = 0; i < arrBi.Length; i++){
        Console.WriteLine("введите у второй точки координату " + coords[i]);
        tempSt = Console.ReadLine();
        tempIn = int.Parse(tempSt);
        arrBi[i] = tempIn;
    }
double summ = 0;
for (int i = 0; i < 3; i++){
    summ = summ + Math.Pow((arrAi[i] - arrBi[i]), 2);
}
double mileage = Math.Round(Math.Sqrt(summ), 2);

Console.Write(mileage);

