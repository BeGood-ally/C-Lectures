int summa(int m, int n){
    if(n == m){
        return m;
    }
    else return n + summa(m, n - 1);
}

Console.Write(summa(3,7));
