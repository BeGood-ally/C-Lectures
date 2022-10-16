void randomArray(int N, int min, int max){
    int[]arr = new int[N];
    for (int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(min,max);
    }
    for (int j = 0; j < arr.Length; j++){
        if (j == 0){
            Console.Write("[" + arr[j] + ", ");
        }
        else if (j == arr.Length - 1){
            Console.Write(arr[j] + "]");
        }
        else {Console.Write(arr[j] + ", ");}
    }
}

Console.WriteLine("введите количество чисел в массиве");
string NInp = Console.ReadLine();
int NInpNum = int.Parse(NInp);
Console.WriteLine("введите минимальное значение диапазона чисел");
string minInp = Console.ReadLine();
int minInpNum = int.Parse(minInp);
Console.WriteLine("введите максимальное значение диапазона чисел");
string maxInp = Console.ReadLine();
int maxInpNum = int.Parse(maxInp);

randomArray(NInpNum,minInpNum,maxInpNum);
