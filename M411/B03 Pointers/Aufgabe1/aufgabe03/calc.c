#include <stdio.h>
#include <stdlib.h>

double cToF(double celsius) {
	double fahrenheit = ((celsius*9.0)/5.0)+32.0;
	return fahrenheit;
}

int main() {
	double test = 32.0;
	double result = cToF(test);
	printf("%f", result);
}
