using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace Set
{
    public class Set<T> : ISet<T>
    {
        private HashSet<T> hashset;

        public Set()
        {
            // do something so bad things don't happen in the future...
            hashset = new HashSet<T>();
        }
        public int Size { get; }

        public List<T> Elements
        {
            get
            {
                // do work

                // return result
                return null;
            }
        }

        // adding a whole other set to another
        public void Add(ISet<T> s)
        {
            foreach(var t in s)
            {
                this.Add(t);
            }
        }

        public void Add(T value)
        {
            hashset.Add(value);
        }

        public bool Contains(T value)
        {
            return hashset.Contains(value);
        }


        public void Remove(ISet<T> s)
        {
            foreach (var t in s)
            {
                this.Remove(t);
            }
        }

        public void Remove(T value)
        {
            hashset.Remove(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return hashset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //method on a class
        public static Set<T> Union(ISet<T> set1, ISet<T> set2)
        {
            var final = set1.Union(set2).ToArray();

            return null;
        }

        public static Set<T> Intersection(ISet<T> set1, ISet<T> set2)
        {
            //var combined = new HashSet<T>();
            var final = set1.Intersect(set2).ToArray();

            return null;
        }
    }
}
