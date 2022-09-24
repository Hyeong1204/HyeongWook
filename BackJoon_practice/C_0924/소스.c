#include <stdio.h>

struct tagStudent {		// 구조체 (사용자 정의 데이터 타입)
	int No;		// 학번	(구조체 멤버)
	int Age;	// 나이
	int Grade;	// 학년
	int ClassNum;	// 반번호
	
};

typedef struct tagStudent Student;

int main(void) {
	
	Student array[10];	// 구조체 배열

	for (int i = 0; i < 10; i++) {
		array[i].No = i;
		array[i].Age = i + 8;
		array[i].Grade = i % 3 + 1;		// 1~4 나옴
	}

	for (int i = 0; i < 10; i++) {
		printf("array[%d].NO = %d\n", i, array[i].No);
		printf("array[%d].Age = %d\n", i, array[i].Age);
		printf("array[%d].Grade = %d\n", i, array[i].Grade);
	}

	return 0;
}