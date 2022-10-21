int[]arr = new int[7];
    for (int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(100,999);
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

int count = 0;
for (int j = 0; j < arr.Length; j++){
    if(arr[j]%2 == 0){
        count++;
    }
}
 Console.Write(" -> " + count);