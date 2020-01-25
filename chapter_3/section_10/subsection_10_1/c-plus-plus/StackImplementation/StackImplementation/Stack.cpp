#include "pch.h"

using namespace std;

// Constructor to initialize stack
Stack::Stack(int size)
{
	arr = new int[size];
	capacity = size;
	top = -1;
}

// Destructor to free memory allocated to the stack
Stack::~Stack()
{
	delete arr;
}

// Utility function to add an element x in the stack
void Stack::push(int x)
{
	if (isFull())
	{
		cout << "Stack Overflow";
	}
	else
	{
		cout << "Inserting " << x << endl;
		arr[++top] = x;
	}
}

// Utility function to pop top element from the stack
int Stack::pop()
{
	// Check for stack underflow
	if (isEmpty())
	{
		cout << "Stack Underflow";
	}
	else
	{
		cout << "Removing " << peek() << endl;
		return arr[top--];
	}
}

// Utility function to return top element of the stack
int Stack::peek()
{
	if (isEmpty())
	{
		cout << "Stack is empty" << endl;
		return -1;
	}
	else
	{
		return arr[top];
	}
}

// Utility function to check if the stack is empty or not
bool Stack::isEmpty()
{
	return top == -1;
}

// Utility function to check if the stack is full or not
bool Stack::isFull()
{
	return top == capacity - 1;
}

int Stack::size()
{
	return top + 1;
}
