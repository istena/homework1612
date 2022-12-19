void InputMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1,11); 
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);Console.Write("Введите позицию элемента в двумерном массиве: ");
string[] position= Console.ReadLine().Split(" ");
if (int.Parse(position[0])<=int.Parse(numbers[0])&&(int.Parse(position[1])<=int.Parse(numbers[1]))) 
    Console.Write("Такая позиция есть в матрице: ");
else Console.Write("Такой позиции нет в  матрице: ");


