string str = "12351";
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
                Console.Write("yes");
                break;
            case "no":
                Console.Write("no");
                break;
        }
    }
    catch(System.FormatException){
       Console.Write("введенная величина не является числом"); 
    }
}
else Console.Write("число не пятизначное");