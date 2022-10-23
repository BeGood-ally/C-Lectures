double [,] Lines = new double[2,2];
string [] Coefficients = new string []{"'k'","'b'"};
string [] LineNumbers = new string []{"первой","второй"};

void fillMatrix(string CoefNum, string DirecNum, int i, int j){
    double signInt;
    while(true){
        Console.WriteLine($"введите коэффициент {CoefNum} {DirecNum} прямой");
        string sign = Console.ReadLine();
        if(double.TryParse(sign, out signInt)){
            Lines[i,j] = signInt;
            break;
        }
        else Console.WriteLine("вы ввели не число, введите численный коэффициент");
    }
}

for (int i = 0; i < 2; i++){
    for (int j = 0; j < 2; j++){
       fillMatrix(Coefficients[j],LineNumbers[i],i,j); 
    }
}

double x = (Lines[1,1] - Lines[0,1])/(Lines[0,0]-Lines[1,0]);
double y = Lines[0,0]*x + Lines[0,1];

Console.WriteLine($"точка пересечения имеет координаты: x = {x}, y = {y}");





