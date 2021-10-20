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


int main()
{	
	char str[50];
	printf("Enter the string to be reversed:");	
	fgets(str, sizeof(str), stdin);
	
	reverse_string(str);

	printf("Reversed String: %s", str);

  system("pause");
	return 0;
}