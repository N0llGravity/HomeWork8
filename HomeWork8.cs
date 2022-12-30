/*//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
void Sort2dArray(int[,] array2d)
{
    for(int i = 0; i < array2d.GetLength(0); i++)
        for(int c = 0; c < array2d.GetLength(1); c++)
            for(int j = 0; j < array2d.GetLength(1)-1-c; j++)
                if (array2d[i,j] < array2d[i,j+1])
                {
                    int temp = array2d[i,j];
                    array2d[i,j] = array2d[i,j+1];
                    array2d[i,j+1] = temp;
                }
}

Console.WriteLine("input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number of colums ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array2d = Create2dAray(rows, colums);
Console.WriteLine();
Show2dArray(array2d);
Console.WriteLine();
Sort2dArray(array2d);
Show2dArray(array2d);
*/

/*//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
*/

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 


/*//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] Create3dArray(int l, int i, int j)
{
    int[,,] array3d = new int[l,i,j];
    return array3d;
}

void FilligArray3d(int[,,] array3d)
{
    int c = 10;
    for(int l = 0; l < array3d.GetLength(0); l++)
        for(int i = 0; i < array3d.GetLength(1); i++) 
            for(int j = 0; j < array3d.GetLength(2); j++)
               {
                    array3d[l,i,j] = c;
                    c++;
               }
}

void Show3dArray(int[,,] array3d)
{
    for(int l = 0; l < array3d.GetLength(0); l++)
    {
        Console.WriteLine($"-------------------------\n Layer {l + 1} \n-------------------------");
        for(int i = 0; i < array3d.GetLength(1); i++)
            {
                for(int j = 0; j < array3d.GetLength(2); j++)
                {
                    Console.Write (array3d[l,i,j] + $"({l},{i},{j})\t");
                }
                Console.WriteLine();
            }
        Console.WriteLine();    
    }   
    Console.WriteLine($"-------------------------\n End of array \n-------------------------");
}

Console.WriteLine("input number of layers ");
int layers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number of colums ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(layers * rows * colums <= 90)
{
    int[,,] array3d = Create3dArray(layers, rows, colums);
    FilligArray3d(array3d);
    Show3dArray(array3d);
}
else
Console.WriteLine("Impossible array size");
*/
// Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] Create2dAray(int rows, int colums)
{
    int[,] array2d = new int[rows, colums];
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

void VortexFillingArray2d(int[,] array2d)
{
    int i = 0;
    int j = 0;
    int c = 1;                                          //Переменная для возрастания заполняемых значений

    int u = 0;                                           //количество по горизонтали
    int v = 0;                                           //количество по вертикали
    int posStepH = array2d.GetLength(1);                 //количество шагов в данной этарации
    int posStepV = array2d.GetLength(0);
    while(c < array2d.Length)
    {
        while(j < array2d.GetLength(1) && posStepH <= array2d.GetLength(1))
        {
            array2d[i,j] = c;
            c++;
            j++;
        }
        j--;
        i++;
        posStepV--;


        while(i < array2d.GetLength(0) && posStepV <= array2d.GetLength(0))
        {
            array2d[i,j] = c;
            c++;
            i++;
        }
        i--;
        j--;
        posStepH--;

        
        while(j >= 0 && posStepH < array2d.GetLength(1))
        {
            array2d[i,j] = c;
            c++;
            j--;
        }
        j++;
        i--;
        posStepV--;


        while(i >= 0 && posStepV < array2d.GetLength(0))
        {
            array2d[i,j] = c;
            c++;
            i--;
        }
        i++;
        j++;
        posStepH--;
    }
}

Console.WriteLine("input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number of colums ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array2d = Create2dAray(rows, colums);
VortexFillingArray2d(array2d);
Console.WriteLine();
Show2dArray(array2d);