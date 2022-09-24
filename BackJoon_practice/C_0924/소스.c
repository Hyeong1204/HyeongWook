#include <stdio.h>

struct tagStudent {		// 구조체 (사용자 정의 데이터 타입)
	int No;		// 학번	(구조체 멤버)
	int Age;	// 나이
	int Grade;	// 학년
	int ClassNum;	// 반번호
	struct tagStudent* Next;		// 다음 학생 노드의 주소값 저장
};

typedef struct tagStudent Student;

int main(void) {
	
	Student a;
	Student b;
	Student c;

	a.No = 1234;
	a.Age = 12;
	a.Grade = 2;
	a.Next = &b;

	b.No = 2345;
	b.Age = 11;
	b.Grade = 4;
	b.Next = &c;

	c.No = 3456;
	c.Age = 12;
	c.Grade = 5;
	c.Next = NULL;

	printf("a.Next->Next->No = %d, a.Next->Next->Age = %d, a.Next->Next->Grade = %d\n",
		a.Next->Next->No, a.Next->Next->Age, a.Next->Next->Grade);


	return 0;
}