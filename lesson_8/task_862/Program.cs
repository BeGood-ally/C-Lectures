int wor = 1;
int [,] digit = {{0,0,0,0},{0,0,0,0},{0,0,0,0},{0,0,0,0}};
void printDigit(int[,]arr, int x, int y){
    while (x < (arr.GetLength(0) - 2) && y < (arr.GetLength(1) - 2)){
        for (int i = y; i < arr.GetLength(1) - y; i++){
            arr[x,i] = wor;
            wor += 1; 
        }
        for (int j = x + 1; j < arr.GetLength(0) - x; j++){
            arr[j,(arr.GetLength(0) - 1) - y] = wor;
            wor += 1; 
        }
        y++;
        for (int i = (arr.GetLength(1) - 1) - y; i > -(1 - x)  ; i--){
            arr[(arr.GetLength(0) - 1) - x,i] = wor;
            wor += 1; 
        }
        x++;
        for (int j = (arr.GetLength(0) - 1) - x; j > -(1 - x) ; j--){
            arr[j,y-1] = wor;
            wor += 1; 
        }
    }
}

void presentDigit(int[,]arr){
for (int j = 0; j < digit.GetLength(0); j++){
        Console.Write("{");
        for (int i = 0; i < digit.GetLength(1); i++){
            if (digit[j,i] < 10){
                Console.Write($"0{digit[j,i]};");
                }
            else Console.Write($"{digit[j,i]};");    
        }
        Console.WriteLine("}");
    }
}

printDigit(digit,0,0);
presentDigit(digit);
