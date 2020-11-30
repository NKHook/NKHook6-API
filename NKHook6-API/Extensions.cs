using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Models.Towers;

namespace NKHook6.API {
    public static class Extensions {

        //IEnumerable Extensions

        /// <summary>
        /// Returns copy of source with allocated additions.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="addition"></param>
        /// <typeparam name="TSource"></typeparam>
        /// <returns></returns>
        public static IEnumerable allocAdd<TSource>(this IEnumerable<TSource> source, TSource addition) {
            foreach (var t in source) {
                yield return t;
            }
            yield return addition;
        }
    }
}