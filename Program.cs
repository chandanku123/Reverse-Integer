internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums ={2,3,4,2,3};
        
            var result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var num = Math.Abs(nums[i]);
                if (nums[num - 1] < 0)
                    result.Add(num);
                else
                    nums[num - 1] *= -1;
            }
            System.Console.WriteLine(result);
        }
}