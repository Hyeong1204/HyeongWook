#include <stdio.h>

struct Student {		// ����ü (����� ���� ������ Ÿ��)
	int No;		// �й�	(����ü ���)
	int Age;	// ����
	int Grande;	// �г�
	int ClassNum;	// �ݹ�ȣ
};


int main(void) {
	
	// �л������� ���α׷�.
	// �й�, �̸�, ����, ����, �г�

	//int No;		// �й�
	//int Age;	// ����
	//int Grande;	// �г�
	//int ClassNum;	// �ݹ�ȣ

	// 100��
	// �迭�� ����

	// ������ ��  ���� ����� �ִ�.
	// ����ü
	struct Student a;

	// ����ü ������ ��� �����Ҷ��� .(period) �����ڸ� ���
	a.No = 123;
	a.Age = 10;
	a.Grande = 2;
	a.ClassNum = 11;

	printf("a.No = %d, a.Age = %d, a.Grade = %d, a.ClassNum = %d\n", a.No, a.Age, a.Grande, a.ClassNum);


	return 0;
}