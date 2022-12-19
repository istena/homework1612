void InputMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1,21); 
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}
void Matrix(int[,] matrix)
{

for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
           Console.Write($"{matrix[i, j]} \t");
        }
       Console.WriteLine();
}
}



Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);
Console.WriteLine();

Matrix(matrix);

