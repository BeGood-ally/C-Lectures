void RandomizeTable(int m,int n){
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
    }}
Random rnd = new Random();
int m1 = rnd.Next(2,5);
int n1 = rnd.Next(2,5);
RandomizeTable(m1,n1);
