#include <stdio.h> 
#include <stdlib.h>
#include <string.h> 

void reverse_string(char* str)
{
	int len, i;
	char *start_ptr, *end_ptr, temp;

  // length of the string inputted
	len = strlen(str);
	
  // start_ptr is equal to base address of str
	start_ptr = str;

  // end_pts is equal to base address of str + the length minus 1
  // String: |_|_|_|_|
  //      str-^     ^-str+4-1
	end_ptr = str+len-1;

  // the two pointers move towards the middle
  // of the buffer
	for (
      i = 0;
      i < len / 2;
      i++
  ) {

    // swapping --> modern JS: [start, end] = [end, start]
		temp = *end_ptr;
		*end_ptr = *start_ptr;
		*start_ptr = temp;
		
    // increase to swap next letter
		start_ptr++; 
		end_ptr--;
	}
}

void reverse_string2(char* str) {
	int len = strlen(str);
	char *start_ptr = str;
	char *end_ptr = str + len - 1;

	int i = 0;
	char temp;

	for (i; i < len / 2; i++) {
		temp = *end_ptr;
		*end_ptr = *start_ptr;
		*start_ptr = temp;

		start_ptr++;
		end_ptr--;
	}
}

void reverse_string_optimiert(char* str) {
	while (*str != '\0') str++;
	while (--str >= *str) printf("%c", *str);
}


int main()
{	
	char str[50];
	char str2[50];
	char str3[50];

	printf("Enter the string to be reversed:");	
	fgets(str, sizeof(str), stdin);
	str2 = str;
	str3 = str;

	reverse_string(str);
	printf("Reversed String: %s", str);

	reverse_string2(str2);
	printf("Reversed String2: %s", str2);

	reverse_string_optimiert(str3);
	printf("Reversed String3: %s", str3);

  	//system("pause");
	return 0;
}