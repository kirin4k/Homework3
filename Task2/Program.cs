Console.WriteLine("\n Dom2");
int[] arr1 = new int[10];

void FillArray1(){
    for(int i=0; i<arr1.Length; i++){
    arr1[i] = new Random().Next(1,50);
    Console.Write($"\t'{arr1[i]}'");
   }
}
FillArray1();
Console.WriteLine();
FindArray1(arr1);
void FindArray1 (int[] array){
    int count1 =0;
    for(int i =0; i< array.Length; i++){
        if(array[i]%2==0){
        count1++;}
    }
    Console.WriteLine($"Количество четных чисел в массиве: '{count1}'");
}
