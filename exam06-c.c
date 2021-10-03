#include <stdio.h>
#include <stdlib.h>

#define days 31
#define p_min 740
#define p_max 780
#define p_norm 760
int pressure[31];
int nDay[31];

int sort(int *n,int *d,int s)
{
for (int i = 0; i < s - 1; i++)
{
for (int j = s - 1; j > i; j--)
{
if (n[j - 1] > n[j])
{
int space = n[j-1];
n[j-1] = n[j];
n[j] = space;

int save = d[j-1];
d[j-1] = d[j];
d[j] = save;
}
}
}
}



int main()
{
printf("Number to delete\n");
int num;

scanf("%d", &num);
num = num - 1;


for(int i = 0; i < days;i++)
{
 pressure[i] = p_min + rand() % (p_max - p_min + 1);
	if(i == num)
 pressure[i] = 0;
}



printf("Number of day\t|Pressure\t\n");
for(int i = 0; i < days; i++)
{
nDay[i] = i + 1;
}

sort(pressure, nDay ,days);

for(int i = 0; i < days; i++)
printf("%d\t\t%d\n",  nDay[i], pressure[i]);

int cnt_below = 0;
int cnt_above = 0;
int cnt_exact = 0;

for(int i = 0; i < days; i++)
{
int v = pressure[i];
if(v < p_norm) cnt_below++;
else if (v > p_norm) cnt_above++;
else cnt_exact++;
}

printf("below: %d\n", cnt_below);
printf("above: %d\n", cnt_above);
printf("exact: %d\n", cnt_exact);

return 0;
}