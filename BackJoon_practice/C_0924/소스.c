#include <stdio.h>

struct tagStudent {		// ����ü (����� ���� ������ Ÿ��)
	int No;		// �й�	(����ü ���)
	int Age;	// ����
	int Grade;	// �г�
	int ClassNum;	// �ݹ�ȣ
	
};

typedef struct tagStudent Student;

int main(void) {
	
	Student array[10];	// ����ü �迭

	for (int i = 0; i < 10; i++) {
		array[i].No = i;
		array[i].Age = i + 8;
		array[i].Grade = i % 3 + 1;		// 1~4 ����
	}

	for (int i = 0; i < 10; i++) {
		printf("array[%d].NO = %d\n", i, array[i].No);
		printf("array[%d].Age = %d\n", i, array[i].Age);
		printf("array[%d].Grade = %d\n", i, array[i].Grade);
	}

	return 0;
}