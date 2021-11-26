#include <stdlib.h>
#include <stdio.h>

#define n_max 10
#define m_max 10
#define vmin 10
#define vmax 20
int n, m;
int **a;
int **b;
int **c1;
int **c2;
char spc[100];
	
void addition()
{
	c1 = (int **)malloc(n*sizeof(int *));
for(int i = 0; i < n; i++) {
    c1[i] = (int *)malloc(m*sizeof(int));
}
	for (int y = 0; y < m; y++)
		for (int x = 0; x < n; x++)
		{
			c1[y][x] = a[y][x] + b[y][x];
			
		}
	
		printf("\n%sc1%s\n", spc, spc);
		
		for (int y = 0; y < m; y++)		
		{
			for (int x = 0; x < n; x++)
				printf("% 4d", c1[y][x]);
			
			printf("\n");
		}
}

void subtraction()
{
		c2 = (int **)malloc(n*sizeof(int *));
for(int i = 0; i < n; i++) {
    c2[i] = (int *)malloc(m*sizeof(int));
}
	for (int y = 0; y < m; y++)
		for (int x = 0; x < n; x++)
		{
			c2[y][x] = a[y][x] - b[y][x];		
		}
	
		printf("\n%sc2%s\n", spc, spc);
		
		for (int y = 0; y < m; y++)		
		{
			for (int x = 0; x < n; x++)
				printf("% 4d", c2[y][x]);
			
			printf("\n");
		}
}

int main()
{
	
	
	
printf("n (cols), m (rows): ");
scanf("%d %d", &n, &m);
a = (int **)malloc(n*sizeof(int *));
for(int i = 0; i < n; i++) 
{
    a[i] = (int *)malloc(m*sizeof(int));
}

b = (int **)malloc(n*sizeof(int *));
for(int i = 0; i < n; i++)
{
    b[i] = (int *)malloc(m*sizeof(int));
}
	
	
	
	 
	for (int y = 0; y < m; y++)
		for (int x = 0; x < n; x++)
		{
			a[y][x] = vmin + rand() % (vmax - vmin + 1);
			b[y][x] = vmin + rand() % (vmax - vmin + 1);
		}
	
		
		for (int i = 0; i < 100; i++)
			spc[i] = ' ';
		spc[n * 4 / 2] = 0;
		
		printf("%sa%s\t%sb\n", spc, spc, spc);
		
	for (int y = 0; y < m; y++)		
		{
			for (int x = 0; x < n; x++)
				printf("% 4d", a[y][x]);
				
			printf("\t");
			
			for (int x = 0; x < n; x++)
			{
				printf("% 4d", b[y][x]);

			}
			
			printf("\n");
		}
		
int choice = -1; 

do
 {
	printf("\n");
	printf("0 - exit\n");
	printf("1 - addition\n");
    printf("2 - subtraction\n");

	printf("\n");
	
	printf("choice: ");
	int choice;
	scanf("%d", &choice);
	
	
	switch(choice)
	{
		case 0: return 0; break;	
		case 1: addition(); break;
		case 2: subtraction(); break;
     
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