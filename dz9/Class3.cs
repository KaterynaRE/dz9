using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dz9
{
	public class RingQueue<T> :IEnumerable<T>
	{

		public Queue<T> Queue;

		public int countL { get; set; } // поточна довжина черги
		public int maxCount { get; set; } // максимальний розмір черги

		public RingQueue(int maxCountP)
		{
			maxCount = maxCountP;
			Queue = new Queue<T>(maxCountP);
			countL = 0;
		}
		public void Enqueue(T item)
		{
			if (countL < maxCount)
			{
				Queue.Enqueue(item);
				countL++;
			}
			else
			{
				Queue.Dequeue();
				Queue.Enqueue(item);
			}

		}

		public T Dequeue()
		{
			if (countL == 0)
			{
				Console.WriteLine("The queue is empty.");
			}
			countL--;
			return Queue.Dequeue();
		}

		public T Peek()
		{
			if (countL == 0)
			{
				Console.WriteLine("The queue is empty.");
			}
			return Queue.Peek();
		}

		public int Count
		{
			get { return countL; }
		}

		public int MaxCount
		{
			get { return maxCount; }
		}
		public IEnumerator<T> GetEnumerator()
		{
			return Queue.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

	}
}
