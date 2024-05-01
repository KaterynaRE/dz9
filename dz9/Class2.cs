using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cl2
{
	class PriorityQueue<TElement, TPriority> : IEnumerable<TElement>
	{ 
		public SortedList<TElement, TPriority> values = new SortedList<TElement, TPriority>();

		public void Enqueue(TElement element, TPriority priority)
		{
			values.Add(element, priority);
		}

		public TElement Dequeue()
		{
			if (values.Count == 0)
			{
				Console.WriteLine("The queue is empty.");
			}
			var item = values.Keys[0];
			values.RemoveAt(0);

			return item;
		}
		public TElement Peek()
		{
			if (values.Count == 0)
			{
				Console.WriteLine("The queue is empty.");
			}
			return values.Keys[0];
		}

		public IEnumerator<TElement> GetEnumerator()
		{
			return values.Keys.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}


	}
}
