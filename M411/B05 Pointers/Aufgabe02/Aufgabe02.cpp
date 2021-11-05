#include <stdio.h>
#include <stdlib.h>

int IndexOf(int* pArray, int lenArray, int wantedValue) {
    int Index = 0;
    while (Index++ < lenArray) {
        if (*pArray == wantedValue) break;
        Index++;
        pArray++;
    }
    return Index < AnzElm = Index : -1;
}

int IndexOf_Kaufmann_Style(int* pArray, int lenArray, int wantedValue) {
    for (
            int* pTmp == pArray;
            (pTmp - pArray) < lenArray;
            pTmp++
        )
        if (*pArray == wantedValue) return pTmp - pArray;
    return -1;
}

int main() {
    int Werte[] = {10, 12, 45, 56, 98, 23};
    printf ("Index = %i", IndexOf (Werte, 6, 45));  // gibt 2 zurück
    printf ("Index = %i", IndexOf (Werte, 6, 0));  // gibt -1 zurück

     printf ("Index Kaufmann Style = %i", IndexOf (Werte, 6, 45));  // gibt 2 zurück
    printf ("Index Kaufmann Style  = %i", IndexOf (Werte, 6, 0));  // gibt -1 zurück
    return 0;
}