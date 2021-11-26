zadacha 10

//na 3 - ""
//na 4 - ""
//na 5 - ""

#include <stdlib.h>
#include <stdio.h>

int main()
{
	#define rows 10
	#define cols 5
	int tab[rows][cols];
	
	
	#define mark0 1
	#define mark1 10
	
	
	for (int y = 0; y < rows; y++)
		for (int x = 0; x < cols; x++)
			tab[y][x] = mark0 + rand() % (mark1 - mark0 + 1);
			
	float avg[rows];
	
	for (int y = 0; y < rows; y++)
	{
		int s = 0;
		  for (int x = 0; x < cols; x++)
			s += tab[y][x];
		avg[y] = s / (float) cols;
	}
			
	printf("\033[1;31mnum");
	for (int x = 0; x < cols; x++)
		printf("\t%d", x + 1);
		
	printf("\tavg\033[0m\n");
	
	for (int y = 0; y < rows; y++)
	{
		printf("\033[1;35m%d\033[0m", y + 1);
		for (int x = 0; x < cols; x++)
			printf("\t%d", tab[y][x]);
			
		printf("\t%.1f", avg[y]);	
		printf("\n");
	}
	return 0;
	
}