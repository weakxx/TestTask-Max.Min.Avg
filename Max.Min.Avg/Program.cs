namespace Max.Min.Avg;

class Program
{
    static void Main(string[] args)
    {
        int rows = 3; 
        int cols = 4; 
        
        int[,] array = new int[rows, cols];
        Random random = new Random();
        
        Console.WriteLine("Array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 101);
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }
        
        for (int i = 0; i < rows; i++)
        {
            int min = array[i, 0];
            int max = array[i, 0];
            int sum = 0;

            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] < min) min = array[i, j];
                if (array[i, j] > max) max = array[i, j];
                sum += array[i, j];
            }

            double average = (double)sum / cols;
            Console.WriteLine($"Line {i + 1}: Min = {min}, Max = {max}, Avg = {average}");

        }
    }
}