int [,] matrixA = {{2,7},{3,4}};
int [,] matrixB = {{3,6},{5,9}};

bool posibilityOfMultiple(int[,]arr1, int[,]arr2){
    if(arr1.GetLength(1) == arr2.GetLength(0)){
        return true;
    }
    else return false;
}

void represent2DArr(int[,]arr){
    for (int j = 0; j < arr.GetLength(0); j++){
        Console.Write("{");
        for (int i = 0; i < arr.GetLength(1); i++){
        Console.Write($"{arr[j,i]};");    
        }
        Console.WriteLine("}");
    }
    }

int[,] multiplicationOfMatrices(int[,]arr1, int[,]arr2){
    if(posibilityOfMultiple(arr1, arr2)){
        int [,] matrixRes = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int j = 0; j < matrixRes.GetLength(0); j++){
            for (int i = 0; i < matrixRes.GetLength(1); i++){
                int elemRes = 0; 
                for (int k = 0; k < arr1.GetLength(1); k++){
                   elemRes = elemRes + (arr1[j,k]*arr2[k,i]); 
                }
                matrixRes[j,i] = elemRes;
            }
        }
        return matrixRes;
    }
    else {return arr1;}
}

represent2DArr(multiplicationOfMatrices(matrixA,matrixB));


