double [,] fromMaxToMin(double[,]arr){
    for (int k = 0; k < arr.GetLength(0); k++){
    int i = 0;
    while (i < arr.GetLength(1)){
        double max = Double.NegativeInfinity;
        int placeOfMax = 0;
        for (int j = i; j < arr.GetLength(1); j++){
            if(max < arr[k,j]){
                max = arr[k,j];
                placeOfMax = j;
            }
        }
        arr[k,placeOfMax] = arr[k,i];
        arr[k,i] = max;
        i++;
    }
    }
    return arr; 
}
void represent2DArr(double[,]arr){
    for (int j = 0; j < arr.GetLength(0); j++){
        Console.Write("{");
        for (int i = 0; i < arr.GetLength(1); i++){
        Console.Write($"{arr[j,i]};");    
        }
        Console.WriteLine("}");
    }
    }

double [,] arrDeclared = {{-10,-7,34},{0,-1,0},{4,7,0}};
represent2DArr(fromMaxToMin(arrDeclared));

