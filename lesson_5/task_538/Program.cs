double[]arr = new double[7];
    for (int i = 0; i < arr.Length; i++){
        arr[i] = Math.Truncate(new Random().NextDouble()*10000)/100;
    }

for (int j = 0; j < arr.Length; j++){
        if (j == 0){
            Console.Write("[" + arr[j] + "; ");
        }
        else if (j == arr.Length - 1){
            Console.WriteLine(arr[j] + "]");
        }
        else {Console.Write(arr[j] + "; ");}
    }

double min = 100;
double max = 0;
for (int i = 0; i < arr.Length; i++){
        if(min > arr[i]){
            min = arr[i];
        }
        else if(max < arr[i]){
            max = arr[i];
        }
    }
Console.Write("разница между максимальным и минимальным элементами массива составляет: " + ((Math.Truncate(max*100 - min*100))/100));


