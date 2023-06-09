Console.WriteLine("Choose matrix size: \n1.2x2; \n2.3x3");

string answer = Console.ReadLine();
int matrixSize = 0;

if (answer == "1")
    matrixSize = 2;
else if (answer == "2")
    matrixSize = 3;



int[,] matrix = new int[matrixSize, matrixSize];

Console.WriteLine("Enter elements:");

for (int i = 0; i < matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        Console.Write("["+i+"]["+j+"]: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("\n");
}


Console.WriteLine("Your matrix is:");

for (int i = 0; i < matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        Console.Write(matrix[i,j]+ " ");
    }
    Console.Write("\n");
}


Console.WriteLine("The determinant of the matrix is:");
if(matrixSize == 2)
    Console.WriteLine(Calculate2dDeterminant(matrix));
else if(matrixSize == 3)
    Console.WriteLine(Calculate3dDeterminant(matrix));









static decimal Calculate2dDeterminant(int[,] m)
{
    return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
}

static int[,] OmitRowAndCol(int[,] m, int row, int col)
{
    int x = 0, y = 0;

    int[,] outputMatrix = new int[m.GetLength(0) - 1, m.GetLength(1) - 1];

    for (int i = 0; i < m.GetLength(0); i++)
    {
        if (i == row)
            continue;

        for (int j = 0; j < m.GetLength(1); j++)
        {
            if(j == col)
                    continue;

            outputMatrix[x,y] = m[i,j];
            
            if(y == outputMatrix.GetLength(1)-1)
            { x ++; y=0;}
            else
            { y++; }

        }
    }

    return outputMatrix;
}

static decimal Calculate3dDeterminant(int[,] m)
{
    decimal result = 0;

    for (int i = 0; i < m.GetLength(1); i++)
    {
        result += m[0, i] * Calculate2dDeterminant(OmitRowAndCol(m, 0, i)) * (decimal)Math.Pow(-1,i);
    }

    return result;
}
