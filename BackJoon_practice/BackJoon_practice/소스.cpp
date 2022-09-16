#include <iostream>

int main(void) {
	int a;
	
	std::cin >> a;

	if (a >= 90) {
		std::cout << "A" << std::endl;
	}
	else if (a >= 80) {
		std::cout << "B" << std::endl;
	}
	else if (a >= 70) {
		std::cout << "C" << std::endl;
	}
	else if(a >=60)
		std::cout << "D" << std::endl;
	else {
		std::cout << "F" << std::endl;
	}
}