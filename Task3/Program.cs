Console.WriteLine("\n Dom3");
double[] arr2 = new double[10];

void FillArray2(){
    for(int i=0; i<arr2.Length; i++){
    arr2[i] = new Random().NextDouble()*10;
    Console.Write($"\t'{Math.Round(arr2[i], 3)}'");
   }
}
FillArray2();
Console.WriteLine();
Console.WriteLine(FindDiference(arr2));

string FindDiference (double[] array){
    double max = array[0], min = array [0];
    for(int i =1; i< array.Length; i++){
        if(array[i]>max) max=array[i];
        if(array[i]<min) min=array[i];
    }
    double diff = max - min;
    return $"Максимальное значение {Math.Round(max, 3)} \n Минимальное значение {Math.Round(min, 3)} \n Разница между максимальным и минимальными элементами массива: {Math.Round(diff, 3)}";
}
