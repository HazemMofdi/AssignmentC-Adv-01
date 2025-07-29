namespace AssignmentC_Adv_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RangeClass<int> range = new RangeClass<int>(2,10);
            int[] arr = { 8, 3, 2, 6, 5, 4, 7, 1 };


            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            range.BubbleSort(arr);
            Console.WriteLine("----After Sorting----");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}
