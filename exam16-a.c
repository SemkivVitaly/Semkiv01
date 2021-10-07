#include <stdio.h>

struct record 
{
		char drug_name[64]; //nazvani
		char indications[64];	//pokazanie
		int exp_years;	//skolko_deistvyer_s_momenta_vipyska
		int mfg_years;	//data_izgotovlenia
};

#define n 3
struct record row[n];

int main()
{
	for (int i = 0; i < n; i++) // считывание инфы с кавиатуры 
		{       
			scanf ("%s %s %d %d", 
					row[i].drug_name, row[i].indications, 
					&row[i].exp_years , &row[i].mfg_years);
		}
		
		printf ("name\tindics\texp\tyear\n");
		
		for (int i = 0; i < n; i++) // вывод инфы  
		{       
			printf("%s\t%s\t%d\t%d\n", 
					row[i].drug_name, row[i].indications, 
					row[i].exp_years , row[i].mfg_years);
		}
		
		return 0;
}
