include <stdio.h>
include <stdlib.h>

char* StringCopy (char *pDestStr, const char *pSourceStr) {
    while( *pSourceStr != '\0') *pDestStr++ = *pSourceStr++;
    *pDestStr = '\0';
    return
}

int main(){
    char Text[255];
    StringCopy (Text, "Das ist ein Text");
    printf ("Text = \"%s\"\n", Text);
    return 0;
}