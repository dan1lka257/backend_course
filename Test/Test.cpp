#include <iostream>
#include <vector>

template <typename T>
void print(T container) {
	int i = 0;
	for (auto elem : container) {
		std::cout << i << ":\t" << elem << '\n';
		++i;
	}
}

int main()
{
	std::vector<double> v;
	v.push_back(0.25);
	for (int i = 0; i < 100; ++i) {
		v.push_back((v[i] + 0.1) * 1.06);
	}
	print(v);
}