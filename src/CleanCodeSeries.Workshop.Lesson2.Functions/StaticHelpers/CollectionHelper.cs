using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson2.Functions.StaticHelpers
{
    public static class CollectionHelper
    {
        public static string ToString(IEnumerable<object> collection)
        {
            var sb = new StringBuilder();

            var array = collection.ToArray();

            for(int index = 0; index < array.Length; index++)
            {
                var line = $"{index}) array[i]";
                sb.AppendLine(line);
            }

            return sb.ToString();
        }

        public static string ToString(IEnumerable collection)
        {
            var message = "";

            var index = 0;
            foreach(var item in collection)
            {
                var line = $"{index}) item";
                message += line + "\r\n";
                index++;
            }

            return message;
        }
    }
}
