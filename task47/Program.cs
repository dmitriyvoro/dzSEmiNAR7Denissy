void InputMatrix(double[,]matrix)
{
    for(int i =0; i<matrix.GetLength(0);i++)
    {
        for(int j=0; j<matrix.GetLength(1);j++)
        {
        matrix[i,j]=Math.Round(new Random().NextDouble()*10,1);
        Console.Write(matrix[i,j]+"\t");
        }
        Console.WriteLine();
    }
}
Console.Write("введите кол-во строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите кол-во столбцов");
int m = Convert.ToInt32(Console.ReadLine());
double[,]matrix=new double[n,m];
InputMatrix(matrix);