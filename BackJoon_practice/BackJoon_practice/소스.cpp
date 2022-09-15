#include <iostream>

int main(void) {
	int a;
	int b;

	std::cin >> a >> b;

	if (a < b)
		std::cout << "<" << std::endl;

	if (a > b)
		std::cout << ">" << std::endl;

	if(a == b)
			std::cout << "==" << std::endl;
	
}