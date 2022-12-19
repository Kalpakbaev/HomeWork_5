//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
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
    int summ = 0;
    for(int i = 0; i< array.Length; i++){
       if(array[i] %2 !=0)
       summ += array[i];
            
    }
    return summ;
}
int size = 10;
int min = -1;
int max = 99;
int [] createdArray = CreateArray(size, min, max);
Console.WriteLine("Here is our array");
ShowArray(createdArray);
Console.WriteLine($"Sum is negative numbers: {CountNumberSegment(createdArray)}");
