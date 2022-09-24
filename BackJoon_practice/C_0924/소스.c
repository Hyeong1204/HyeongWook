#include <stdio.h>

struct Student {		// 구조체 (사용자 정의 데이터 타입)
	int No;		// 학번	(구조체 멤버)
	int Age;	// 나이
	int Grande;	// 학년
	int ClassNum;	// 반번호
};


int main(void) {
	
	// 학생관리용 프로그램.
	// 학번, 이름, 나이, 성별, 학년

	//int No;		// 학번
	//int Age;	// 나이
	//int Grande;	// 학년
	//int ClassNum;	// 반번호

	// 100명
	// 배열을 쓴다

	// 하지만 더  좋은 방법이 있다.
	// 구조체
	struct Student a;

	// 구조체 변수의 멤버 접근할때는 .(period) 연산자를 사용
	a.No = 123;
	a.Age = 10;
	a.Grande = 2;
	a.ClassNum = 11;

	printf("a.No = %d, a.Age = %d, a.Grade = %d, a.ClassNum = %d\n", a.No, a.Age, a.Grande, a.ClassNum);


	return 0;
}