using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDMWinPhone
{
    public static class IListExtensions
    {
        public static void AddSorted<T>(this IList<T> collection, T item, bool orderDescending = false, IComparer<T> comparer = null)
        {
            if(comparer == null && !(item is IComparer<T>))
            {
                collection.Add(item);
            }
            else
            {
                if(comparer == null)
                {
                    comparer = Comparer<T>.Default;
                }

                int index = 0;

                if (!orderDescending)
                {
                    while(index < collection.Count && comparer.Compare(collection[index], item) > 0)
                    {
                        index++;
                    }
                }
                else
                {
                    while(index < collection.Count && comparer.Compare(collection[index], item) < 0)
                    {
                        index++;
                    }
                }
                collection.Insert(index, item);
            }
        }
    }
}
