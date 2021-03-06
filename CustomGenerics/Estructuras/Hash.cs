using System;
using System.Collections.Generic;
using System.Text;


using CustomGenerics.Estructuras;
using System.Linq;
using System.Threading.Tasks;



namespace CustomGenerics.Estructuras
{
    public class Hash<T> where T : IComparable
    {

        //Referenciado de https://www.codeproject.com/Questions/1239153/Csharp-copy-list-of-objects-without-reference
        HashNode<T>[] TablaHash = new HashNode<T>[50];

        public void Insert(T InsertV, string key)
        {
            HashNode<T> T1 = new HashNode<T>();
            T1.Value = InsertV;

            T1.Key = key;
            int code = GetCode(T1.Key);
            if (TablaHash[code] != null)
            {
                HashNode<T> Aux = TablaHash[code];
                while (Aux.Next != null)
                {
                    Aux = Aux.Next;
                }
                Aux.Next = T1;
                T1.Previous = Aux;
            }
            else
            {
                TablaHash[code] = T1;
            }
        }

        public HashNode<T> Search(string searchedKey)
        {
            int code = GetCode(searchedKey);

            if (TablaHash[code] != null)
            {

                if (TablaHash[code].Key != searchedKey)
                {
                    HashNode<T> Aux = TablaHash[code];
                    while (Aux.Key != searchedKey && Aux.Next != null)
                    {
                        Aux = Aux.Next;
                    }
                    if (Aux.Key == searchedKey)
                    {
                        return Aux;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return TablaHash[code];
                }
            }
            else
            {
                return null;
            }
        }

        public void Delete(string searchedKey)
        {
            int code = GetCode(searchedKey);

            if (TablaHash[code] != null)
            {

                if (TablaHash[code].Key != searchedKey)
                {
                    HashNode<T> Aux = TablaHash[code];
                    while (Aux.Key != searchedKey && Aux.Next != null)
                    {
                        Aux = Aux.Next;
                    }
                    if (Aux.Key == searchedKey)
                    {
                        if (Aux.Next != null)
                        {
                            Aux.Next.Previous = Aux.Previous;
                        }
                        if (Aux.Previous != null)
                        {
                            Aux.Previous.Next = Aux.Next;
                        }
                        if (Aux.Next == null && Aux.Previous == null)
                        {
                            Aux = null;
                        }
                    }
                }
                else
                {
                    if (TablaHash[code].Next != null)
                    {
                        TablaHash[code] = TablaHash[code].Next;
                    }
                    else
                    {
                        TablaHash[code] = TablaHash[code].Next;
                    }
                }
            }
        }


        private int GetCode(string Key)
        {
            int _vowels = 0;
            var vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            foreach (var vowel in vowels)
            {
                if (Key.Contains(vowel))
                {
                    _vowels++;
                }
            }
            return (Key.Length + _vowels) * 11 % 50;
        }

        public List<HashNode<T>> GetTasksAsNodes()
        {
            var listOfTasks = new List<HashNode<T>>();
            var currentNode = new HashNode<T>();
            foreach (var task in TablaHash)
            {
                currentNode = task;
                while (currentNode != null)
                {
                    listOfTasks.Add(currentNode);
                    currentNode = currentNode.Next;
                }
            }
            return listOfTasks;
        }



    }
}
