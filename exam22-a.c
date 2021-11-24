#include <stdio.h>
#include <string.h> //strcpy()
#include <stdlib.h>

struct theRow
{
	char title[50];
	char mfg[100];
	short year;
	int price;
};

#define rowNum 3
struct theRow row[rowNum];

void outputTable()
{
	
	for(int i = 0; i < rowNum; i++)
	printf("%s\t%s\t%d\t%d\n", row[i].title, row[i].mfg, row[i].year, row[i].price);
}


int main()
{

	
	strcpy(row[0].title, "Video Adapter");
	strcpy(row[0].mfg, "Nvidia");
	row[0].year = 2020;
	row[0].price = 40000;
	strcpy(row[1].title, "Hard Drive");
	strcpy(row[1].mfg, "Western Digital");
	row[1].year = 2019;
	row[1].price = 5000;
	strcpy(row[2].title, "Sound Card");
	strcpy(row[2].mfg, "Realtek");
	row[2].year = 2015;
	row[2].price = 1000;
	
	FILE *theWriteBinFile = fopen("exam22.bin", "wb+");
	fwrite(row, sizeof(struct theRow), 3, theWriteBinFile);
	fclose(theWriteBinFile);



	FILE *theReadFile = fopen("exam22.bin", "rb+");
	fread(row, sizeof(struct theRow), 3, theReadFile);
	fclose(theReadFile);

	outputTable();

	
	char xTitle[50];
	printf("find: ");
	fgets(xTitle, 50, stdin);

	char *p = strchr(xTitle, '\n');
	if (p != NULL) *p = 0;
	p = strchr(xTitle, '\r');
	if (p != NULL) *p = 0;

	
	int thereIsNoXTitle = 1;
	for(int i = 0; i < rowNum; i++)
	if (strcmp(row[i].title, xTitle) == 0)
	{
		puts(row[i].mfg);
		thereIsNoXTitle = 0;
	}
	if(thereIsNoXTitle == 1)
	printf("No title found\n");

	


	return 0;
}
