#pragma once
#define SIZE 3

class MyQueue
{
private:
	int *arr;
	int capacity;
	int head;
	int tail;
	int count;

public:
	MyQueue(int size = SIZE);
	~MyQueue();

	void enqueue(int);
	int dequeue();

	int headValue();
	int tailValue();
	int size();
	bool isEmpty();
	bool isFull();
};