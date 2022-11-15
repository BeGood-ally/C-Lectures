void threeOneTwo(int[,,]arr){
    for (int i = 0; i < arr.GetLength(2); i++){
        for (int j = 0; j < arr.GetLength(0); j++){
            for (int k = 0; k < arr.GetLength(1); k++){
                Console.Write($"{arr[j,k,i]}({j},{k},{i}) ");
            }
            Console.WriteLine("");
        }
    }
    }

int [,,] d3arr = {{{12,45},{64,55}},{{42,79},{66,71}}};
threeOneTwo(d3arr);
