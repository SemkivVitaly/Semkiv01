#include <stdio.h> // FILE, fopen(), fscanf(), fclose()

#define max_ans 5
#define max_txt 100

struct quest
{
	int nans;
	int corr;
	char txt[max_txt];
	char ans[max_ans][max_txt];

};

#define max_quest 10
struct quest test[max_quest];


void testing()
{
	char imia[16];
	char familia[16];
	char group[5];
	printf("Enter your familia ");
	scanf("%s", &familia);
	printf("Enter your imua ");
	scanf("%s", &imia);
	printf("Enter your group ");
	scanf("%s", &group);
	int c[max_quest];
	
	FILE *f = fopen("exam19.txt", "r");
	
	int nq;
	fscanf(f, "%d", &nq);
	
	for(int i = 0; i < nq; i++)
	{
		fscanf(f, "%d %d\n", &test[i].nans, &test[i].corr);
		fgets(test[i].txt, max_txt, f);
		for(int j = 0; j < test[i].nans; j++)
					fgets(test[i].ans[j], max_txt, f);
		
	}
	
	fclose(f);
	
	for(int i = 0; i < nq; i++)
	{
		printf(test[i].txt);
		for(int j = 0; j < test[i].nans; j++)
				printf(test[i].ans[j]);
		
		scanf("%d", &c[i]);
		
		if (c[i] == test[i].corr) puts("correct!");
		else puts("wrong!");
	}
	
	FILE *s = fopen("otvet.txt", "w");
	fprintf(s,"FIO = %s %s \ngroup = %s\n", familia, imia, group);
	for(int i = 0; i < nq; i++)
	{
		fprintf(f,"Vopros %d\n", i + 1);
		fprintf(f,test[i].txt);
		fprintf(f,"Selected otvet %d ", c[i]);
		if (c[i] == test[i].corr) fprintf(f,"correct!\n");
		else fprintf(f,"wrong!\n");
	}
	fclose(s);
}

void redaktor()
{
	int aq;
	char s[256];
	char a[256];
	FILE *r = fopen("exam19.txt", "w+");
	printf("Enter amount of quastion\n");
	scanf("%d", &aq);
	int nq[aq],ra[aq];
	fprintf(r,"%d\n",aq);
	for(int i = 0;  i< aq;i++)
	{
		printf("Enter amount of answer and number of right answer(Separated by a space)\n");
		scanf("%d %d", &nq[i], &ra[i]);
		fprintf(r,"%d %d\n", nq[i], ra[i]);
		printf("Enter a quastion \n");
		scanf("%s", &s[i]);
		fprintf(r,"%s\n", s[i]);
		printf("Enter the answer \n");
		for(int n = 0; n < nq[i]; n++)
		{
			printf("%d ", n + 1);
			scanf("%s", &a[n]);
			fprintf(r,"%s\n", a[i]);
		}
	
	}
	
	fclose(r);
}



int main()
{
int choice = -1; 

do
 {
	printf("\n");
	printf("0 - exit\n");
	printf("1 - input 1\n");
	printf("2 - input 2\n");
	
	printf("\n");
	
	printf("choice: ");
	int choice;
	scanf("%d", &choice);
	
	
	switch(choice)
	{
		case 0: return 0; break;
		case 1: testing(); break;
		case 2: redaktor(); break;
		
	}
    printf("\n");
	printf("press");
    printf("\n");
 }
 while(choice != 0);
	
	
	
	return 0;

	switch(choice)
	{
	case 0: return 0; break;
	}
	
}
