Console.WriteLine("введите пятизначное число");
string str = Console.ReadLine();
if (str.Length == 5){
    try {
        int strNum = int.Parse(str);
        string answer = "yes";
        for (int i = 0; i < 2; i++){
            if (str[i] != str[(str.Length - 1) - i]){
                answer = "no";
                break;
            }
            else continue;
        }
        switch(answer){
            case "yes":
                Console.Write("да");
                break;
            case "no":
                Console.Write("нет");
                break;
        }
    }
    catch(System.FormatException){
       Console.Write("введенная величина не является числом"); 
    }
}
else Console.Write("число не пятизначное");