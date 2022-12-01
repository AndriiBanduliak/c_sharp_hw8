using static System.Console;
Clear();

WriteLine("\nEnter the sizes of the matrices and the range of random values: ");
int m = InputNumbers("Enter the number of rows of the 1st matrix: ");
int n = InputNumbers("Enter the number of columns of the 1st and rows: ");
int s = InputNumbers("Enter the numbers of rows of the 2nd matrix: ");
int p = InputNumbers("Enter the number of columns of the 2nd matrix: ");
int range = InputNumbers("Enter a range of random numbers: from 0 to ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
WriteLine($"\nFirst matrix:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[s, p];
CreateArray(secomdMartrix);
WriteLine($"\nSecond matrix:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
WriteLine($"\nMultiplication of the first and the second matrices:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Write(input);
    int output = Convert.ToInt32(ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        WriteLine();
    }
}