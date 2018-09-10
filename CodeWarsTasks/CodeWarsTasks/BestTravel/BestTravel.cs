using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeWarsTasks.BestTravel
{
    class BestTravel
    {
        public static Int32 chooseBestSum(int t, int k, List<Int32> ls)
        {
            if (ls.Count < k || k == 0) return -1;
            List<Int32> distances = getDists(k, ls);
            distances.Sort();
            if (distances.Contains(t)) return t;
            for (int i = distances.Count - 1; i >= 0; i--)
                if (distances[i] < t) return distances[i];
            return -1;
        }
        public static List<Int32> getDists(int k, List<Int32> list)
        {
            List<Int32> dists = new List<Int32>();
            if (k == 1)
            {
                foreach (int i in list)
                    dists.Add(i);
                return dists;
            }
            int prevSize = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int currElem = list[i];
                dists.AddRange(getDists(k - 1, list.GetRange(1 + i, list.Count - 1 - i)));
                for (int j = prevSize; j < dists.Count; j++)
                    dists[j] = dists[j] + currElem;
                prevSize = dists.Count;
            }
            return dists;
        }
    }
}