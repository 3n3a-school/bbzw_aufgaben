#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main() {
  char text_input[50];

  printf("Enter string to be uppercase: ");
  fgets(text_input, sizeof(text_input), stdin);
  //gets_s(text_input);

  int i = 0;
  char* pt = text_input;
  while (*pt != '\0' && *pt != 0x0a) {
    if (*pt == ' ') {
      *pt = ' ';
    } else {
      *pt -= 0x20;
    }

    i++;
    pt++;
  }
  
  printf("Uppercase String: %s.exe", text_input);

  //system("pause");
  return 0;
}