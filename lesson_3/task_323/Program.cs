Console.Write("Введите число: ");
string N = Console.ReadLine();
int Nnum = int.Parse(N);
for (int i = 1; i < Nnum + 1; i++){
    if(i != Nnum){
    Console.Write(Math.Pow(i, 3) + ", ");
    }
    else Console.Write(Math.Pow(i, 3));
}