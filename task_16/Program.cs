// See https://aka.ms/new-console-template for more information
string a = Console.ReadLine();
int ai = int.Parse(a);
switch(ai%2){
    case 0:
        Console.WriteLine("число четное");
        break;
    case 1:
        Console.WriteLine("число нечетное");
        break;
}
