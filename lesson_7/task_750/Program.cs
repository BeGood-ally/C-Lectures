//Функция заполнения массива
void FillArr(int [,] arr){
    Random rand = new Random();
    for (int j = 0; j < arr.GetLength(0); j++){
        for (int i = 0; i < arr.GetLength(1); i++){
            arr[j,i] = rand.Next(-10,10);
        }
}
}
//Функция поиска значения
string FindValue(int [,] arr, int m, int n){
    string value = "";
    try{
        if(arr[m,n] is int){
            value = $"значение элемента в ряду {m} и столбце {n} равно: {arr[m-1,n-1].ToString()}";
        }
    }
    catch(System.IndexOutOfRangeException) {
        value = "такого числа в массиве нет";}
    return value;
}

//Введение размеров массива и его создание
Console.WriteLine("введите количество строк");
int m1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n1 = int.Parse(Console.ReadLine());
int [,] arr = new int[m1,n1];

//Вызов функции заполнения массива
FillArr(arr);

//Введение индекса искомого элемента
Console.WriteLine("введите номер строки для поиска элемента");
int row1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите номер столбца для поиска элемента");
int collumn1 = int.Parse(Console.ReadLine());

//Вызов функции поиска элемента
Console.WriteLine(FindValue(arr, row1, collumn1));
for (int j = 0; j < m1; j++){
    Console.Write("[");
    for (int i = 0; i < n1; i++){
        Console.Write($"{arr[j,i]}, ");
    }
    Console.WriteLine("]");
    }