Console.WriteLine("Dom1");
int[] arr = new int[10];

void FillArray(){
    for(int i=0; i<arr.Length; i++){
    arr[i] = new Random().Next(1,101);
    Console.Write($"\t'{arr[i]}'");
   }
}
FillArray();
Console.WriteLine();
int answer = FindArray(arr);
Console.WriteLine($"Количество чисел в промежутке от 20 до 90: '{answer}'");


int FindArray (int[] array){
    int count =0;
    for(int i =0; i< array.Length; i++){
        if(array[i]>=20 && array[i]<=90){
        count++;}
    }
    return count;
}


