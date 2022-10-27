//Функция создания массива
double[,] RandomizeTable(int m,int n){
    Random rand = new Random();
    int y = 0;
    double [,] arr = new double[m,n];
    for (int j = 0; j < m; j++){
        for (int i = 0; i < n; i++){
            while(true){
            y = rand.Next(-1,2);
            if(y == 0) continue;
            else break;
            }
            arr[j,i] = Math.Round(rand.NextDouble()*10*y,2);
        }
    }
    for (int j = 0; j < m; j++){
        Console.Write("{");
        for (int i = 0; i < n; i++){
        Console.Write($"{arr[j,i]}; ");    
        }
        Console.WriteLine("}");
    }
    return arr;
    }

//Функция выведения средних арифметических значений столбцов массива на экран
   void SummOfCollumns(double[,]arr){
        int collumns = arr.GetLength(1);
        double[]SummCol = new double[collumns];
        for (int i = 0; i < arr.GetLength(1); i++){
            double summ = 0;
            double average = 0;
            for (int j = 0; j < arr.GetLength(0); j++){
                summ = summ + arr[j,i];
            }
            average = summ/arr.GetLength(1);
            SummCol[i] = average;
        }
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < SummCol.Length; i++){
        Console.Write((Math.Round(SummCol[i],2)) + "; ");  
    }
    }

double[,] arr1 = RandomizeTable(3,3);
SummOfCollumns(arr1);
  