namespace ejercicioexplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<long> list = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            //Program.aVeryBigSum(list);
            List<List<int>> list = new List<List<int>>();
            list.Add(new List<int> { 11, 2, 4 });
            list.Add(new List<int> { 4, 5, 6 });
            list.Add(new List<int> { 10, 8, - 12 });
            Program.diagonalDifference(list);


        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int absoluteOne = 0;
            int absoluteTwo = 0;
            int suma = 0;
            for(int i=0; i < arr.Count; i++)
            {
                List<int> InnerList = arr[i];
                for (int j=0;j < InnerList.Count; j++)
                {
                    Console.WriteLine(InnerList[j]);
                    int valueOne = Convert.ToInt32(InnerList[j]);
                    absoluteOne += valueOne;
                }
            }
            suma= absoluteOne - absoluteTwo;
            return Math.Abs(suma);

        }

        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
            foreach(long v in ar)
            {
                sum+= v;
            }
            return sum;

        }

        public void Prueba()
        {
            List<int> nums = new List<int>() { 5, 6, 7 };
            List<int> nums1 = new List<int>() { 3, 6, 10 };
            List<int> listPoinst = new List<int>();

            int alicia = 0;
            int bob = 0;
            for (int i = 0; i < 3; i++)
            {
                if (nums[i] > nums1[i]) alicia++;
                if (nums[i] < nums1[i]) bob++;
            }
            Console.WriteLine(listPoinst);
        }


    }
}