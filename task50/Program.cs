//Денис привет , про поиск с единицы пользователем я помню ,
//плоховато я еще с матрицами , буду подтягивать этот момент
//решил как смог , про object поверхностно знаю с ютуба :)
 void InputMatrix(int[,]matrix)
 {
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix [i, j] = Convert.ToInt32(new Random().Next(1,11));  
    }
 }

void PtintMatrix(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i,j] + "\t  ");
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
InputMatrix(matrix);
PtintMatrix(matrix);
Console.WriteLine("Введите номер строки");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int colums = Convert.ToInt32(Console.ReadLine());
if (row>matrix.GetLength(0) && colums>matrix.GetLength(1))
Console.WriteLine("error");
 else
 {
 object result= matrix.GetValue(row,colums);//GetValue поиск элемента
 Console.WriteLine(result);
 }