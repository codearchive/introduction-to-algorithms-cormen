#include "pch.h"

using namespace std;

// Constructor to initialize queue
MyQueue::MyQueue(int size)
{
	arr = new int[size];
	capacity = size;
	head = 0;
	tail = -1;
	count = 0;
}

// Destructor to free allocated memory
MyQueue::~MyQueue()
{
	delete arr;
}

int MyQueue::size()
{
	return count;
}

bool MyQueue::isEmpty()
{
	return size() == 0;
}

bool MyQueue::isFull()
{
	return size() == capacity;
}

int MyQueue::headValue()
{
	if(isEmpty())
	{
		cout << "Queue is empty" << endl;
	}
	else
	{
		return arr[head];
	}
}

int MyQueue::tailValue()
{
	if (isEmpty())
	{
		cout << "Queue is empty" << endl;
	}
	else
	{
		return arr[tail];
	}
}

void MyQueue::enqueue(int item)
{
	if (isFull())
	{
		cout << "Queue Overflow" << endl;
	}
	else
	{
		cout << "Inserting " << item << endl;
		tail = (tail + 1) % capacity;
		arr[tail] = item;
		count++;
	}
}

int MyQueue::dequeue()
{
	if (isEmpty())
	{
		cout << "Queue Underflow" << endl;
		return INT_MIN;
	}
	else
	{
		int x = arr[head];
		cout << "Removing " << x << endl;
		head = (head + 1) % capacity;
		count--;
		return x;
	}
}