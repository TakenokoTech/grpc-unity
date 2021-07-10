using System;
using System.Collections.Generic;
using System.Linq;

namespace Script.utils
{
    public static class EnumerableExtension
    {
        public static IEnumerable<(int index, T value)> WithIndex<T>(this IEnumerable<T> source, int startIndex = 0)
        {
            return source.Select((t, i) => (i+startIndex, t));
        }
        
        public static void Foreach<T>(this IEnumerable<T> source, Action<T> block)
        {
            foreach (var t in source) block(t);
        }
        
        public static IEnumerable<T> FilterNull<T>(this IEnumerable<T> source)
        {
            return source.Where(t => t == null);
        }
        
        public static IEnumerable<T> FilterNotNull<T>(this IEnumerable<T> source)
        {
            return source.Where(t => t != null);
        }
    }
}