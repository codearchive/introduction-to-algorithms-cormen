#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	class Stack stack;
	cout << "Is stack empty?\n\t" << stack.isEmpty() << endl;
	stack.push(10);
	cout << "Is stack empty?\n\t" << stack.isEmpty() << endl;
	stack.push(20);
	stack.peek();
	cout << "Size of stack: " << stack.size() << endl;
	stack.pop();
	stack.pop();
	cout << "Is stack empty?\n\t" << stack.isEmpty() << endl;
	stack.push(30);
	cout << stack.pop() << " Popped from stack\n";

	return 0;
}
