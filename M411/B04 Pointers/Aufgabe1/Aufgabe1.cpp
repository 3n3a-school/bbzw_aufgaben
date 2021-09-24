#include <stdio.h>
#include <stdlib.h>

void main() {
	int numbers[] = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; // in square brackets no number needed, will be set to number of elements iputted
	int size_numbers = sizeof(numbers) / sizeof(numbers[0]); // size of all elements in array in bytes; divide by size of one item in array

	for (int* num = numbers; num < numbers + size_numbers; num++) { // two pointers subtracetd from each other, get amount of elements in between
		printf("%i\n", *num);
	}

	system("pause");
}