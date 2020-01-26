#include "pch.h"

using namespace std;

int main()
{
	MyQueue myQueue;

	cout << "Is queue empty?\n\t";
	if (myQueue.isEmpty())
	{
		cout << "true" << endl;
	}
	else
	{
		cout << "false" << endl;
	}
	
	myQueue.enqueue(5);

	cout << "Is queue empty?\n\t";
	if (myQueue.isEmpty())
	{
		cout << "true" << endl;
	}
	else
	{
		cout << "false" << endl;
	}

	myQueue.enqueue(6);
	myQueue.enqueue(7);

	cout << "Head: " << myQueue.headValue() << endl;
	cout << "Tail: " << myQueue.tailValue() << endl;
	cout << "Is queue full?\n\t";
	if (myQueue.isFull())
	{
		cout << "true" << endl;
	}
	else
	{
		cout << "false" << endl;
	}

	myQueue.enqueue(8);
	myQueue.dequeue();

	cout << "Head: " << myQueue.headValue() << endl;
	cout << "Tail: " << myQueue.tailValue() << endl;

	myQueue.enqueue(1);

	cout << "Head: " << myQueue.headValue() << endl;
	cout << "Tail: " << myQueue.tailValue() << endl;

	myQueue.dequeue();
	myQueue.dequeue();
	myQueue.dequeue();
	myQueue.dequeue();
	
	cout << "Is queue full?\n\t";
	if (myQueue.isFull())
	{
		cout << "true" << endl;
	}
	else
	{
		cout << "false" << endl;
	}

	myQueue.dequeue();

	cout << "Is queue empty?\n\t";
	if (myQueue.isEmpty())
	{
		cout << "true" << endl;
	}
	else
	{
		cout << "false" << endl;
	}

	return 0;
}