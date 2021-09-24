#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void main() {
  int numbers[10];
  int* num = numbers;


  srand(time(NULL));
  for (int* num = numbers; num - numbers < (sizeof(numbers) / sizeof(numbers[0])); num++) {
    *num = rand() % 10 + 1;
  }

  int sum = 0;
  for (int* num = numbers; num - numbers < (sizeof(numbers) / sizeof(numbers[0])); num++) {
    sum += *num;
  }

  double median = sum / (sizeof(numbers) / sizeof(numbers[0]));
  printf("Sum: %i\nMedian: %.2lf\n", sum, median);

  system("pause");
}