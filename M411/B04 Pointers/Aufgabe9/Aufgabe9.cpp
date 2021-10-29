#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main() {
  char text_input[50];

  printf("Enter string to be uppercase: ");
  //fgets(text_input, sizeof(text_input), stdin);
  //gets_s(text_input);

  for (char* pt = fgets(text_input, sizeof(text_input), stdin); *pt != '\0' && *pt != 0x0a;) (*pt >= 'a' && *pt <= 'z') ? (*pt++ -= 0x20) : *pt++;
  
  printf("Uppercase String: %s", text_input);

  //system("pause");
  return 0;
}