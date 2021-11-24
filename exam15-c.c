
#include <stdio.h>
#include <string.h>
#include <limits.h>

struct record
{
	char osNames[32];
	int virtualMemory; 
	int physicalMemory; 
	int price; 
	float res; 
};


#define numOfRows 3
struct record row[numOfRows];

int main()
{
	char tmp[32];
	for(int i = 0; i < numOfRows; i++)
	{
		printf("[record %d]\OS, virtual Memory, physical Memory, price: ", i);
		scanf("%s %d %d %d", row[i].osNames, &row[i].virtualMemory,
		&row[i].physicalMemory, &row[i].price);
		printf("\n");
	}

	{
		printf("|\tOS\t|\tVirtM\t|\tPhysM\t|\tPrice\t|\n");
		for(int i = 0; i < numOfRows; i++)
		printf("|\t%s\t|\t%d\t|\t%d\t|\t%d\t|\n", row[i].osNames, row[i].virtualMemory,
		row[i].physicalMemory, row[i].price);
	}

	{
		char  osNameUserInput[32];
		printf("search: ");
		scanf("%s31", osNameUserInput);
		printf("\n");
		for(int i = 0; i < numOfRows; i++)
		{
			if (strcmp(row[i].osNames, osNameUserInput) == 0)
			{
				printf("virtual Memory: %d\n", row[i].virtualMemory);
				printf("physical Memory: %d\n", row[i].physicalMemory);
			}
		}
	}

	{
		int minPrice = INT_MAX;
		for(int i = 0; i < numOfRows; i++)
		{
			if(row[i].price <= minPrice) minPrice=row[i].price;
		}
		printf("lowest price: %d", minPrice);
	}

	{
		FILE *theUpdateFile = freopen("exam15-c.txt", "w", stdout);
		printf("|\tOS\t|\tVirtM\t|\tPhysM\t|\tPrice\t|\n");
		for(int i = 0; i < numOfRows; i++)
		printf("|\t%s\t|\t%d\t|\t%d\t|\t%d\t|\n", row[i].osNames, row[i].virtualMemory,
		row[i].physicalMemory, row[i].price);
		fclose(theUpdateFile);
	}


	return 0;

}
