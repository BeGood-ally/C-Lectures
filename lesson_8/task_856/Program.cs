double [,] arr = {{-10,-7,4},{0,-1,0},{4,7,0},{-10000,-50,-1000000}};
double strWithMinSumm(){
    double summConst = Double.PositiveInfinity;
    double strNum = 0;
    for (int k = 0; k < arr.GetLength(0); k++){
        double summTemp = 0;
            for (int j = 0; j < arr.GetLength(1); j++){
                summTemp = summTemp + arr[k,j];
            }
            if(summTemp < summConst){
                summConst = summTemp;
                strNum = k;
            } 
        }
        return strNum; 
        }
Console.Write($"наименьшая сумма элементов находится в строке: {strWithMinSumm()+1}");
    
