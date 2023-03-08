using ProblemOne.Model;
using System.Collections.Concurrent;

namespace ProblemOne.KGraph
{
    public static class KPathExtention
    {
        public static IEnumerable<KCoordinates> AsCoordinates<T>(this KPath<T> path) where T : KVertex
        {
            HashSet<KCoordinates> coord = new HashSet<KCoordinates>();
            foreach (T v in path)
                coord.Add(new KCoordinates() { ColumnIndex = v.ColumnIndex, RowIndex = v.RowIndex });
            return coord;
        }
    }

    public class KPath<T> : ConcurrentBag<T> where T : KVertex
    {
        public int Length
        {
            get { return this.Sum(v => v.Weight); }
        }
    }
}
