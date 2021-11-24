#include <stdio.h>
#include <stdlib.h>

int writeFile(int days, float valueLow, float valueHight)
{

	FILE *theWriteFile = freopen("exam09-c.txt", "w", stdout);
	for(int i = 0; i < days; i++)
	printf("%f\n", (valueLow + ((valueHight - valueLow) * rand() / RAND_MAX)));
	fclose(theWriteFile);
	return 0;
}

int main()
{


	int days =  31;
	float valueLow =  10.0f;
	float valueHight = 50.0f;
	float valueX = -1.0f;
	float value[days];
	float scanSymbol;


	FILE *theReadFile = fopen("exam09-c.txt", "r");

	if(theReadFile == NULL) writeFile(days, valueLow, valueHight);
	int j = 0;
	while (j < days)
	{
		fscanf(theReadFile, "%f", &value[j]);
		
		j++;
	}
	fclose(theReadFile);

	
	printf("|\tday\t|\t$\t|\n");
	for(int i = 0; i < days; i++)
	{
		printf("|\t%d\t|\t%.2f\t|\n", i+1, value[i]);
	}


	printf("from %.0f to %.0f\n", valueLow, valueHight);
	printf("Find value (all symbol): ");
	scanf("%f", &valueX);
	if(valueX > valueHight)
	printf("It's too hight\n");
	if(valueX < valueLow)
	printf("It's too low\n");

	
	float valueMin = valueHight;
	float valueMax = valueLow;
	for(int i = 0; i < days; i++)
	{
		
		if(value[i] == valueX )
		{
			printf("Finding value: %.2f\n", value[i]);
			printf("Finding day: %d\n", i+1);
		}
		if(value[i] < valueMin)
		valueMin = value[i];
		if(value[i] > valueMax)
		valueMax = value[i];
	}

	
	printf("min = %.2f\n", valueMin);
	printf("max = %.2f\n", valueMax);

	return 0;
}
