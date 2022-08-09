using System.Collections;

namespace Assignment_1_MET1_
{
    internal static class ProgramHelpers
    {

        private static void Batsman()
        {
            int runs = 0;
            int sum = 0;
            Hashtable map = new Hashtable();
            Random rand = new Random();
            for (int i = 0; i <= 30; i++)
            {
                runs = Convert.ToInt32(rand.Next(1, 6));
                Console.WriteLine(runs);
                sum = sum + runs;
                if (map.ContainsKey(runs))
                {
                    map[runs] = Convert.ToInt32(map[runs]) + 1;
                }
                else
                {
                    map.Add(runs, 1);
                }
            }

            Console.WriteLine(sum);
            foreach (int key in map.Keys)
            {
                String count = String.Format("Runs:{0} Count:{1}", key, map[key]);
                Console.WriteLine(count);
            }

            String strike = String.Format("Strike Rate : {0}", (sum / 30) * 100);
            Console.WriteLine(strike);


        }
    }
}