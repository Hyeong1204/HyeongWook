#include <stdio.h>

struct Student {		// ����ü (����� ���� ������ Ÿ��)
	int No;		// �й�	(����ü ���)
	int Age;	// ����
	int Grade;	// �г�
	int ClassNum;	// �ݹ�ȣ
};

int main(void) {
	
	struct Student a;
	struct Student* pa = &a;

	// ����ü�� ����� �����Ҷ� ����ü ������ �ּҰ����� �����ϴ� ��쿡��
	// ->(ȭ��ǥ������)�� �����ؾ� �Ѵ�.

	pa->No = 23454;
	pa->Age = 11;
	pa->Grade = 2;
	pa->ClassNum = 5;

	printf("pa->No = %d, pa->Age = %d, pa->Grade = %d, pa->ClassNum = %d\n"
		, pa->No, pa->Age, pa->Grade, pa->ClassNum);




	return 0;
}