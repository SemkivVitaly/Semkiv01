zadacha 11

//na 3 - "В группе 25 студентов информация о результатах сессии представлена в виде таблицы в которой строки это оценки по 5-ой системе, информация представлена массивом 25 на 5, заполнить случайным образом, для каждого предмета рассчитать средний балл"
//na 4 - "Дополнительно указать предмет который хуже всего был сдан по среднему баллу"
//na 5 - "Для каждого предмета указать кол-во двоек, троек, четверок и пятерок"

#include <stdlib.h>
#include <stdio.h>

int main()
{
	#define rows 25
	#define cols 5
	int tab[rows][cols];
	
	
	#define mark0 2
	#define mark1 5
	
	
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