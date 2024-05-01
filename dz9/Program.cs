using cl2;
using cl5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
	internal class Program
	{
		static void Swap<T>(ref T num1, ref T num2)
		{
			T temp = num1;
			num1 = num2;
			num2 = temp;
		}

		static void Main(string[] args)
		{
			//Завдання 1
			//Створіть generic-версію методу Swap для обміну значеннями двох змінних.

			int num1 = 10;
			int num2 = 20;
			Console.WriteLine($"Numbers before Swap: num1 {num1}, num2 {num2}");
			Swap(ref num1, ref num2);
			Console.WriteLine($"Numbres after swap: num1: {num1}, num2: {num2}"); 

			string str1 = "Hello";
			string str2 = "World";
			Console.WriteLine($"\nString before Swap: str1 {str1}, str2 {str2}");
			Swap(ref str1, ref str2);
			Console.WriteLine($"String after Swap: str1: {str1}, str2: {str2}");

			//Завдання 2
			//Створіть generic-клас «Черга» з пріоритетами. Реалізуйте стандартні методи
			//і властивості для роботи черги із пріоритетами.

			PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
			priorityQueue.Enqueue(10, 1);
			priorityQueue.Enqueue(2, 4);
			priorityQueue.Enqueue(5, 9);

			Console.WriteLine("Priority Queue: \n");
            foreach (var item in priorityQueue)
            {
				Console.Write(item + " ");
            }

			Console.WriteLine("\nAfter dequeue: \n");
			priorityQueue.Dequeue();
			foreach (var item in priorityQueue)
			{
				Console.Write(item + " ");
			}


			//Завдання 3
			//Створіть generic-клас «Кільцева Черга». Реалізуйте стандартні методи і властивості для
			//роботи кільцевої черги.

			int maxCount = 8;
			RingQueue<int> ringQueue = new RingQueue<int>(maxCount);

			ringQueue.Enqueue(1);
			ringQueue.Enqueue(33);
			ringQueue.Enqueue(44);
			ringQueue.Enqueue(50);

			Console.WriteLine("\nRing Queue: \n");
			foreach (var item in ringQueue)
            {
				Console.Write(item + " ");
            }

			ringQueue.Dequeue();
			Console.WriteLine("\nRing Queue after Dequeue: \n");
			foreach (var item in ringQueue)
			{
				Console.Write(item + " ");
			}

			Console.WriteLine($"\nPeek: {ringQueue.Peek()}");

			//Завдання 4
			//Створіть generic-клас однозв’язний список. Реалізуйте
			//стандартні методи і властивості для роботи однозв’язкового списку.

			Queue<int> valuesQ = new Queue<int>();
			valuesQ.Enqueue(2);
			valuesQ.Enqueue(6);
			valuesQ.Enqueue(1);
			valuesQ.Enqueue(12);


			Console.WriteLine("\nQueue: \n");
			foreach (var item in valuesQ)
			{
				Console.Write(item + " ");
			}

			int numC = 2;
			Console.WriteLine($"\nContains find {numC} in queue: {valuesQ.Contains(numC)}");

			valuesQ.Dequeue();
			Console.WriteLine("\nQueue after delete: \n");
			foreach (var item in valuesQ)
			{
				Console.Write(item + " ");
			}

			Console.WriteLine($"\nPeek: {valuesQ.Peek()}");

			//Завдання 5
			//Створіть generic-клас для двозв’язкового списку.
			//Реалізуйте стандартні методи і властивості для роботи
			//двозв’язкового списку.

			MyLinkedList<int> myLinkedList = new MyLinkedList<int>();

			myLinkedList.AddFirst(10);
			myLinkedList.AddFirst(20);
			myLinkedList.AddLast(30);
			myLinkedList.AddLast(40);

			Console.WriteLine("Linked List Elements:");
			foreach (var item in myLinkedList)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine($"Count: {myLinkedList.countE}");

			myLinkedList.Clear();
			Console.WriteLine($"Count after clearing: {myLinkedList.countE}");


		}
	}
}
