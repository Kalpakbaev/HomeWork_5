//  Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//  значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов.
//  В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] CreateArray(int size, int minValue, int maxValue){
    int [] array = new int[size];
    for(int i=0; i<size; i++){
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void ShowArray(int [] array){
    Console.Write("[ ");
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}


int CountNumberSegment(int [] array){
    int count = 0;
    for(int i = 0; i< array.Length; i++){
        if(array[i]>10 && array[i] < 99)
            count++;
    }
    return count;
}
int size = 123;
int min = 0;
int max = 123;
int [] createdArray = CreateArray(size, min, max);
Console.WriteLine("Here is our array");
ShowArray(createdArray);
Console.WriteLine($"The number of digits in the segment 10 and 99 : {CountNumberSegment(createdArray)}");


