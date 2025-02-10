#include <iostream>
#include <vector>
#include <algorithm>
#include <deque>

template <typename T>
void print(T container) {
	for (auto elem : container) {
		std::cout << elem << ' ';
	}
	std::cout << '\n';
}

int main()
{
	std::deque<int> d;
	print(d);
}