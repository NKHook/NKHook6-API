using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NKHook6.API {
    public static class Extensions {

        //IEnumerable Extensions
        public static IEnumerable<TSource> allThatApply<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> condition) where TSource : class {
            IEnumerator enumerator = source.GetEnumerator();
            while (enumerator.MoveNext())
                if (condition(enumerator.Current as TSource))
                    yield return enumerator.Current as TSource;
        }

        /// <summary>
        /// Does an action to all members of an IEnumerable.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="action"></param>
        /// <typeparam name="TSource"></typeparam>
        public static void @do<TSource>(this IEnumerable<TSource> source, Action<TSource> action) where TSource : class {
            IEnumerator enumerator = source.GetEnumerator();
            while (enumerator.MoveNext())
                action(enumerator.Current as TSource);
        }

        /// <summary>
        /// Does an action if a member of an IEnumerable meets a predicate.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="predicate"></param>
        /// <param name="action"></param>
        /// <typeparam name="TSource"></typeparam>
        public static void doIf<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Action<TSource> action) where TSource : class {
            IEnumerator enumerator = source.GetEnumerator();
            while (enumerator.MoveNext())
                if (predicate(enumerator.Current as TSource))
                    action(enumerator.Current as TSource);
        }

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