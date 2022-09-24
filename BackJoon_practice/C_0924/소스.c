#include <stdio.h>

// 함수로 전달된 인자값을 받는 변수를 매개변수(Parameter)
int add(int a, int b) {   // call by value
	return a + b;
}

void padd(int* pa, int* pb, int* pret) { // call by address
	*pret = *pa + *pb;
}


// 함수를 호출할때 인자값의 전달 방식
// Call by Value (값의 의한 호출)
// Call by Address   (주소의 의한 호출)

int main() {
	int a = 10;
	int b = 20;

	int ret = add(a, b);   // 함수를 호출할때 전달하는 값을 인자(argument)

	printf("%d + %d = %d\n", a, b, ret);

	a = 40;
	b = 50;
	padd(&a, &b, &ret);
	printf("%d + %d = %d\n", a, b, ret);


	return 0;
}