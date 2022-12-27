//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Create2dAray(int rows, int colums)
{
    int[,] array2d = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array2d[i,j] = new Random(). Next(0,11);

    return array2d;
}

void Show2dArray(int[,] array2d)
{
    for(int i = 0; i < array2d.GetLength(0); i++)
        {
            for(int j = 0; j < array2d.GetLength(1); j++)
            {
                Console.Write (array2d[i,j] + "\t");
            }
            Console.WriteLine();  
        }
}

void FindSmallSumRow(int[,] array2d)
{
    int[] answerArray = new int[3];                         //первое значение будет номер строки c минмальной суммой, второе - последняя сумма, третье - последняя минимальаня сумма

    for(int i = 0; i < array2d.GetLength(0); i++)
        {
            for(int j = 0; j < array2d.GetLength(1); j++)
            {
                answerArray[1] += array2d[i,j];
                if(i == 0)
                    answerArray[2] = answerArray[1];        // записываем первые значения в любом случае для дальнейшего сравнения
                if(answerArray[2] > answerArray[1])
                {
                    answerArray[2] = answerArray[1];
                    answerArray[0] = i;
                }
                answerArray[1] = 0;
            }
            
        } 
    Console.WriteLine($"The row with minimal sum is {answerArray[0] + 1}");
}


Console.WriteLine("input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number of colums ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array2d = Create2dAray(rows, colums);
Console.WriteLine();
Show2dArray(array2d);
Console.WriteLine();
FindSmallSumRow(array2d);

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Напишите программу, которая заполнит спирально массив 4 на 4.
