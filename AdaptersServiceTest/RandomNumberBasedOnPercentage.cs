using AdaptersServiceTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersServiceTest
{
    public class RandomNumberBasedOnPercentage
    {
        public static Random random = new();

        public static Item SelectItem(List<Item> items)
        {
            int poolSize = 0;
            for (int i = 0; i < items.Count; i++)
            {
                poolSize += items[i].percentage;
            }

            int randomNumber = random.Next(0,poolSize) + 1;

            int accumulateProbability = 0;
            for (int i = 0; i < items.Count; i++)
            {
                accumulateProbability += items[i].percentage;
                if(randomNumber <= accumulateProbability)
                {
                    return items[i];
                }
            }
            return null;
        }

    }

    
}
