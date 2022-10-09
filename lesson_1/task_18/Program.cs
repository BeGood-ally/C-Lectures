string a = Console.ReadLine();
int ai = int.Parse(a);
for (int i = 2; i <= ai; i = i + 2){
    if (i < ai && i != ai - 1){
        Console.Write(i+", ");
    }
    else if(i == ai || i == ai - 1){
        Console.Write(i);
    }
}