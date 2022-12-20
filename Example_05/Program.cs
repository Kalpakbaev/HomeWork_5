// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int [] CreateArray(int size, int min, int max){
    int [] array = new int [size];
    for(int i = 0; i<size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int [] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int [] MultArray(int [] array){
    int L = array.Length;
    int count = 1;
    for(int i = 1; i<L/2; i++){
         int temp = array[i];
         array[i] = array[L-1-i];
         array[L-1-i] = temp;
         count *= temp;
    }
    return array;
}
Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array max: ");
int max = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(size,min,max);
ShowArray(array);
int [] revarray = MultArray(array);
ShowArray(revarray);

