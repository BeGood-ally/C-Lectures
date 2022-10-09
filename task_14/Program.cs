// See https://aka.ms/new-console-template for more information
string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();
int ai = int.Parse(a);
int bi = int.Parse(b);
int ci = int.Parse(c);
if (ai <= bi){
    if (bi >= ci){
        Console.WriteLine("max "+bi);
    }
    if (bi < ci){
        Console.WriteLine("max "+ci);
    }
    }
if (ai > bi) {
    Console.WriteLine("max "+ai);
}

