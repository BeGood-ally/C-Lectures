int [] arrA = {2,4,6};
int [] arrB = {1,2,3};
double summ = 0;
for (int i = 0; i < 3; i++){
    summ = summ + Math.Pow((arrA[i] - arrB[i]), 2);
}
double mileage = Math.Round(Math.Sqrt(summ), 2);
Console.Write(mileage);

