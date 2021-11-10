#include <stdio.h>
#include <stdlib.h>

int main()
{
	#define months 12
	int salary[months];

	#define salary_low 1000
	#define salary_high 5000
	float tax = 0;
	for(int i = 0; i < months; i++)
		salary[i] = salary_low + rand() % (salary_high - salary_low + 1);
	printf("  ");
	for(int i = 0; i < months; i++)
	{
		tax = salary[i] * 0.02f; //2%
	}	
	
	int year_sum = 0;
	for(int i = 0; i < months; i++)
			year_sum += salary[i];
	
	
	
	float year_avg = year_sum / (float) months;
	for(int i = 0; i < months; i++)
		printf("% 6d ", (i + 1));

	int otkl = 0;

	printf("\n");
	for(int i = 0; i < months; i++)
		printf("% 7d", salary[i]);
	printf("\n");
	for(int i = 0; i < months; i++)
	printf("% 7.1f", tax);
	printf("\n");
	 for(int i = 0; i < months; i++)
	{
		otkl = abs(salary[i] - year_avg);
		printf("% 7d", otkl);
	}
	printf("\n");
	printf("year_sum = %d\n", year_sum);
	printf("year_avg = %.2f\n", year_avg);
	int min = salary[0];
	int max = 0;
	int dmin = 0;
	int dmax = 0;
	for(int i = 0; i < months; i++)
	{
		if(salary[i] < min )
		{
		min = salary[i];
		dmin = i;
		}
		
		if(max < salary[i])
		{
		max = salary[i];
		dmax = i;
		}
	}
	printf("min_zarp = %d mounf = %d\n", min, dmin + 1);
	printf("max_zarp = %d mounf = %d\n", max, dmax + 1);
	
return 0;
}