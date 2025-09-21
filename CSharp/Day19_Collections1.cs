/*collection is a group of objects that we can store, retrieve, manipulate and iterate.
collections can shrink and grow at runtime.
*/

/* Categories of Collections(System.Collections):
1) Non-Generic Collections(less type safe):
  ArrayList, HashTable, SortedList, Stack, Queue

2) Generic Collectons(type-safe)System.Collections.Generic():
 List<T>, Dictionary<TKey,TValue>m SortedList<TKey, TValue>, Queue<T>, Stack<T>, HashSet<T>

3) Concurrent Collections -System.Collections.Concurrent
4) Specialized Collections
*/


// NON GENERIC COLLECTION
using System.Collections;

class NonGeneric1
{
    static void Main()
    {
        // ArrayList
        ArrayList list1 = new ArrayList();
        list1.Add(10);
        list1.Add("Hello");
        list1.Add(2.12);

        foreach (var item in list1)
        {
            Console.WriteLine(item);
        }

        //HashTable -> stores key-value pairs (key must be unique)
        Hashtable ht1 = new Hashtable();
        ht1["id"] = 101;
        ht1["name"] = "John";
        Console.WriteLine(ht1["name"]);
        
    }
}