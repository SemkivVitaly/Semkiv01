//zadacha 20
//na 3 - "Имеется текст в текстовом файле, выведите самую длинную строку в этом файле и ее длину"
//na 4 - "Дополнительно для каждой строки в конце дописать ее длину" 
//na 5 - "Дополнительно  выровните строки исходного файла по самой длинной строке текста..
//..     не достоющие символы дописать в конце каждой строки в виде нужного кол-во звездочек..
//..	 измененый текст поместить в файл.

#include <stdio.h> //FILE, fopen(), fclose(), fgets()
#include <string.h> // srlen(), strcpy(), strchr()

#define max_txt 256

int main()
{
	FILE *f = fopen("exam20.txt", "r");
	
	int m = 0;
	char p[max_txt];
	
	while(1)
	{
		char s[max_txt];
		if (fgets(s, max_txt, f) == NULL) break;
		
		char *c = strchr(s, '\n');
		if(c != NULL) *c = '\0';
	
		int l = strlen(s);
		printf("%s %d\n", s, l);
		if (l > m)
		{
			m = l;
			strcpy(p, s);
		}
		
		
	}
	
	printf("str = %s\n", p);
	printf("len = %d\n", m);
	
	fclose(f);
	
	return 0;
	
	
}