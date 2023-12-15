Console.WriteLine("Dom4");
Console.Write("Введите число в диапазоне от 1 до 100 000: "); 
string num = Console.ReadLine();
int size = num.Length;
int number = Convert.ToInt32(num);

int[] array = new int[size];
MakeAndPrintArray(array);

void MakeAndPrintArray(int[] arr){
for(int i=arr.Length-1; i>=0; i--){
    arr[i] = number%10;
    number= number/10;
}
for(int i = 0; i<arr.Length; i++){
    Console.Write($"\t '{arr[i]}'");
}
}