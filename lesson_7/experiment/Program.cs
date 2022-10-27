int [,] arr = {{2,3,4},{5,6,7}};
int r = -4;
bool e = Convert.ToBoolean(r);
Console.Write(arr[1,0]);
Console.Write(arr[1,0].ToString());


bool flag;
if (arr[1,0] is int){
    Console.Write($"flag");
}