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
        public int Size => hashset.Count;

        public List<T> Elements => new List<T>(hashset);
        //{
            //new List<T>(HashSet) = 
            //get { return hashset.ToList(); }
        //}

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
            if(hashset.Contains(value))
            {
                //return hashset.Contains(value);
                return true;
            }
            return false;
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
            //created new list
            var newList = new Set<T>();

            
            // add both sets
            if(newList != null)
            {
                newList.Add(set1);
                newList.Add(set2);
            }
            // return 
            return newList;
            
        }

        public static Set<T> Intersection(ISet<T> set1, ISet<T> set2)
        {
            var newlist = new Set<T>();
            var sameNum = new Set<T>();
            //HashSet<T> set3 = new HashSet<T>();
            foreach (var t in set1)
            {
                if(set2.Contains(t))
                {
                    newlist.Add(set1);
                    sameNum.Add(t);
                    newlist.Remove(t);
                }
                
            }
            foreach(var t in set2)
            {
                if (set1.Contains(t))
                {
                    newlist.Add(set2);
                    sameNum.Add(t);
                    newlist.Remove(t);
                }
            }
            return newlist;

            if(newlist != set1 && newlist != set2)
            {
                return null;
            }
        }
    }
}
