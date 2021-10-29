#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void removePrependedSpaces() {
  char text_input[50], text_output[50];

  printf("Enter string to be cleaned: ");
  fgets(text_input, sizeof(text_input), stdin);
  //gets_s(text_input);
  char *pSrc = Text;
  char *pDst = Text;

  while (*pSrc == ' ') pSrc++;
  while(*pSrc != '\0') {
    *pDst = *pSrc;
    pSrc++;
    pDst++;
  }
  printf("Cleaned String: %s", text_output);
}

void removeAllSpaces() {
  char text_input[50], text_output[50];

  printf("Enter string to be cleaned: ");
  fgets(text_input, sizeof(text_input), stdin);
  //gets_s(text_input);
  int i = 0;
  int array_pos = 0;
  char* pt = text_input;
  while (*pt != '\0') {
    if (*pt != ' ') {
      text_output[array_pos] = *pt;
      array_pos++;
    }

    i++;
    pt++;
  }
  printf("Cleaned String: %s", text_output);
}

int main() {
  char chosen;
  printf("Choose option: ");
  fgets(chosen, sizeof(chosen), stdin);
  
  if (chosen == 'a') {
    removeAllSpaces();
  } else {
    removePrependedSpaces();
  }
  
  //system("pause");
  return 0;
}