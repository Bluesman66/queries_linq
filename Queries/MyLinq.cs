﻿using System;
using System.Collections.Generic;

namespace Queries.Ling
{
    static class MyLinq
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            var result = new List<T>();

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        } 
    }
}