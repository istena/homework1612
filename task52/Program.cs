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
Console.Write("Среднее арифметическое каждого столбца:");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
           sum+=matrix[i,j]; 
        }
       if (j!=(matrix.GetLength(1)-1)) Console.Write($"{Math.Round((sum/matrix.GetLength(0)),1)}; ");
       else Console.Write($"{Math.Round((sum/matrix.GetLength(0)),1)}");
}
}



Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);
Matrix(matrix);
