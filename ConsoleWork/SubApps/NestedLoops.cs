namespace ConsoleWork.SubApps
{
    public class NestedLoops
    {
        public static void Run()
        {
            // Example dimensions for a 4D array
            int dim1 = 3,
                dim2 = 3,
                dim3 = 3,
                dim4 = 3;

            Console.WriteLine("Iterating through a 4D space:");
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    for (int k = 0; k < dim3; k++)
                    {
                        for (int l = 0; l < dim4; l++)
                        {
                            // Print the indices of the current element
                            Console.WriteLine($"Element at ({i}, {j}, {k}, {l})");
                        }
                    }
                }
            }
        }
    }
};