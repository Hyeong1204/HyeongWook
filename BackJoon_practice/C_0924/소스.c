#include <stdio.h>

int main(void) {
	int array[101];

	for (int i = 0; i < 101; i++) {
		array[i] = i;
	}

	for (int i = 0; i < 101; i++) {
		printf("array[%d] = %d\n", i, array[i]);
	}
}