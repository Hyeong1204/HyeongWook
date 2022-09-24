#include <stdio.h>

struct Student {		// 구조체 (사용자 정의 데이터 타입)
	int No;		// 학번	(구조체 멤버)
	int Age;	// 나이
	int Grade;	// 학년
	int ClassNum;	// 반번호
};

int main(void) {
	
	struct Student a;
	struct Student* pa = &a;

	// 구조체의 멤버에 접근할때 구조체 변수의 주소값으로 접근하는 경우에는
	// ->(화살표연산자)로 접근해야 한다.

	pa->No = 23454;
	pa->Age = 11;
	pa->Grade = 2;
	pa->ClassNum = 5;

	printf("pa->No = %d, pa->Age = %d, pa->Grade = %d, pa->ClassNum = %d\n"
		, pa->No, pa->Age, pa->Grade, pa->ClassNum);




	return 0;
}