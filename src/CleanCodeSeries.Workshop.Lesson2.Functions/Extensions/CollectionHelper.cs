using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCodeSeries.Workshop.Lesson2.Functions.StaticHelpers
{
    public static class CollectionsExtensions
    {
        public static string Print<T>(this IEnumerable<T> collection)
        {
            var sb = new StringBuilder();

            var index = 0;
            foreach(var item in collection)
            {
                var line = $"{index}) {item}";
                sb.AppendLine(line);
                index++;
            }

            return sb.ToString();
        }

        public static string Print(this IEnumerable collection)
        {
            var genericCollection = collection.Cast<object>();
            return Print(genericCollection);
        }
    }
}
