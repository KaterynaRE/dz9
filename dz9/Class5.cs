using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace cl5
{
	public class LinkedListNode<T>
	{
		public T Value { get; set; }
		public LinkedListNode<T> Next { get; set; }
		public LinkedListNode<T> Previous { get; set; }

		public LinkedListNode(T value)
		{
			Value = value;
		}

	
	}


	public class MyLinkedList<T> : IEnumerable<T>
	{
		public LinkedListNode<T> first;
		public LinkedListNode<T> last;
		public int countE;

		public void AddFirst(T value)
		{
			LinkedListNode<T> newNode = new LinkedListNode<T>(value);

			if (first == null)
			{
				first = newNode;
				last = newNode;
			}
			else
			{
				newNode.Next = first;
				first.Previous = newNode;
				first = newNode;
			}

			countE++;
		}

		public void AddLast(T value)
		{
			LinkedListNode<T> newNode = new LinkedListNode<T>(value);

			if (first == null)
			{
				first = newNode;
				last = newNode;
			}
			else
			{
				last.Next = newNode;   //l хранит пос на нов
				newNode.Previous = last;  //нова хран посил на попередній
				last = newNode;   // встанов посил ласт на нов вузол
			}
			countE++;
		}

		public void Clear()
		{
			first = null;
			last = null;
			countE = 0;
		}

		public LinkedListNode<T> FindLast(T value)
		{
			LinkedListNode<T> current = last;
			while (current != null)
			{
				if (EqualityComparer<T>.Default.Equals(current.Value, value))   //порівнюємо значення вузла з валює
				{
					return current; // Повертаємо вузол, якщо знайдено значення
				}
				current = current.Previous; // Переходимо до попереднього вузла
			}
			return null;
		}

		public void RemoveLast()
		{
			if (last == null)
			{
				Console.WriteLine("The list is empty.");
			}
			if (first == last)
			{
				// Якщо є тільки один вузол у списку, очищаємо список
				first = null;
				last = null;
			}
			else
			{
				last = last.Previous;  //останній тепер посилається на останній попередній
				last.Next = null;     // той вузол посилається на нічого, т.к видалено останній вузол
			}
			countE--;
		}
		public IEnumerator<T> GetEnumerator()
		{
			LinkedListNode<T> current = first;
			while (current != null)
			{
				yield return current.Value; // Повертаємо значення поточного вузла
				current = current.Next; // Переходимо до наступного вузла
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator(); // Викликаємо реалізацію типізованого GetEnumerator
		}

	}
}