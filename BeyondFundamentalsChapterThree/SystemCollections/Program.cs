namespace SystemCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Array.Sort(array);
            var numbers = new Dictionary<int, double>();
            for (int i = 0; i < array.Length; i++)
            {
                numbers.Add(i, array[i]);
            }
            //MyDict.GroupBy(x => x.Value).Where(x => x.Count() > 1)
            var result = from num in numbers
                         group num by num.Value into g
                         where g.Count() > 1
                         select g;


            foreach (var r in result)
            {
                var sameValue = (from p in r
                                 orderby p.Key descending
                                 select p.Key + "").ToArray();

                Console.WriteLine("{0} -> {1} times", r.Key, r.Count());
            }
        }
    }
}