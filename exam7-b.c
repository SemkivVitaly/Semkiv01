#include <stdio.h>
#include <stdlib.h>

#define n_max 100

int n;
int mmax, mmin;
int mark[n_max];
float avg;
#define mmin 2
#define mmax 5

#define mpass 4.6f

void float f(int n, int *mark)
{
	int sum = 0;
	for (int i = 0; i < n; i++)
    	sum += mark[i];
		
    avg = (float) sum / (float) n;
	
}

int main()
{
    printf("n: ");
    scanf("%d", &n);
	
	printf("Marks:");
	
	for (int i = 0; i < n; i++)
	{
		scanf("%d", &mark[i]);
		if(mark[i]<mmin)
		{
		printf("Error\n");
		return 0;
		}
		if(mark[i]>mmax)
		{
		printf("Error\n");
		return 0;
		}
	}
	
	f(n);

    printf("avg: %.1f\n", avg);
    if (avg >= mpass) printf("yes\n");
    else printf("no\n");

    return 0;
	

}