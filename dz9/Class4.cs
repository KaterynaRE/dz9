using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcl4
{
	class Queue<T> : IEnumerable<T>
	{

		Queue<T> values = new Queue<T>();

		public void Enqueue(T item)
		{
			values.Enqueue(item);
		}

		public bool Contains(T item)
		{
			return values.Contains(item);
		}

		public void Clear() 
		{ 
			values.Clear();
		}

		public void Dequeue()
		{
			values.Dequeue();
		}

		public T Peek()
		{
			return values.Peek();
		}

		public IEnumerator<T> GetEnumerator()
		{
			return values.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

	}
}
