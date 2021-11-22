//15
//na 3 - "Заполнить таблицу инфой и вывести на экран, выдать аппаратные требования для установленной на вашем ПК ОС, название ОС вводится пользователем"
//na 4 - "Дополнительно подобрать конфигурацию программных средств по минимальной цене"
//na 5 - "Дополнительно сохранить конфигурацию программных средств в текстовый файл"

#include <stdio.h> 
#include <string.h>

struct record
{
	char os[32];
	int virt;
	int phy;
	int price;
	
	float res;
};


#define rows 3
struct record tab[rows];

int main()
{
	char tmp[32];
	for(int i = 0; i < rows; i++)
	{
		printf("[record %d]\nos, virt, phy, price : ", i);
		scanf ("%s %d %d %d", tab[i].os, &tab[i].virt, &tab[i].phy, &tab[i].price);
		printf("\n");
		
	}
		
	for(int i = 0; i < rows; i++)
			printf("%s\t%d\t%d\t%d\n", tab[i].os, tab[i].virt, tab[i].phy, tab[i].price);
		
	char os[32];
	printf("search: ");
	scanf("%s", os);
	printf("\n");
	
	for(int i = 0; i < rows; i++)
	{
		if (strcmp(tab[i].os, os) == 0)
		{
			printf("virt: %d\n", tab[i].virt);
			printf("phy: %d\n", tab[i].phy);
		}
	}
	
	return 0;
	
}