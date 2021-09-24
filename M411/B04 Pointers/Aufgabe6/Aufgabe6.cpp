#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void main() {
  char Text[100];

  printf("Enter text: ");
  gets_s(Text);

  printf("Text: %s\n", Text);

  int i = 0;
  char* pt = Text;
  while (*pt != '\0') {
    i++;
    pt++;
  }

  printf("Length string: %d\n", i);

  system("pause");
}