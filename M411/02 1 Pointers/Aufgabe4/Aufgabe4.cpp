#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
	double Quadrat = 81.0;
	 double *pQuadrat = &Quadrat;
	 printf("Quadrat = %lf\n", *pQuadrat);
	 printf("Zahl = %lf\n", sqrt(*pQuadrat));
	 system("pause");
	 return 0;
}