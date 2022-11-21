string sequence(int a){
    if (a > 1){
       return $"{a}," + sequence(a - 1); 
    }
    else return "1";
}

Console.Write(sequence(9));