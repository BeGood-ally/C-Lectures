int Akkerman(int m, int n){
    if (m == 0){
        return n + 1;
        }
    else if (n == 0){
        return Akkerman(m - 1, 1);
        }
    else {
        return Akkerman(m - 1, Akkerman(m, n - 1));
        }
}

Console.WriteLine(Akkerman(2,3));
Console.Write(Akkerman(3,2));