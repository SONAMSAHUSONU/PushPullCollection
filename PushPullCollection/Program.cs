using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushPullCollection
{
    class Program
    {
        public static void Main(string[] args)
        {
            //we are using stack to push the data or pop the data
            //push are given the output down to up value
            Stack<string> name = new Stack<string>();
            name.Push("Priya");
            name.Push("Priya");
            name.Push("Peehu");
            name.Push("Pinki");
            name.Push("Pinku");
            name.Push("Pinku");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=============");
            Console.WriteLine(name.Peek());

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            name.Pop();
            Console.WriteLine("================");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================");
            name.Pop();
            name.Pop();
            Console.WriteLine("================");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================");
            
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            name.Clear();
            Console.WriteLine("===============");
            Queue<int> IQ = new Queue<int>();
            IQ.Enqueue(100);
            IQ.Enqueue(200);
            IQ.Enqueue(300);
            IQ.Enqueue(400);
            foreach (var item in IQ)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================");
            Queue<int> IQE = new Queue<int>();
            IQE.Enqueue(100);
            IQE.Enqueue(200);
            IQE.Enqueue(300);
            IQE.Enqueue(400);
            IQE.Dequeue();
            foreach (var item in IQ)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================");
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1,"jp");
            keyValuePairs.Add(2, "BLR");
            keyValuePairs.Add(3, "BSp");
            keyValuePairs.Add(4, "UD");
            foreach (KeyValuePair<int,  string> item in keyValuePairs)
            {
                Console.WriteLine(item.Key+":"+item.Value);
            }
            Console.WriteLine("=========================");
            SortedDictionary<string, string> SDL = new SortedDictionary<string, string>();
            SDL.Add("a", "jp");
            SDL.Add("b", "BLR");
            SDL.Add("c", "BSp");
            SDL.Add("d", "UD");
            foreach (KeyValuePair<string, string> item in SDL)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.WriteLine("===============");
            LinkedList<string> Link = new LinkedList<string>();
            Link.AddFirst("AS");
            Link.AddLast("AA");
            Link.AddLast("AD");
            Link.AddFirst("ASO");
            foreach (var item in Link)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            

        }
    }
}
