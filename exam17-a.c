#include <stdio.h>
#include <string.h> 

int main()
{
		char s[256];
		   
		fgets(s, 256, stdin);
		
		char *p = strchr(s, '\n'); 
		if (p != NULL) p[0] = '\0';
		
		size_t n = strlen(s);
		
		printf("len: %ld\n", n);
		
		int m = 0;
		for (int i = 0; i < n; i++)
		{
			 if (s[i] == ' ') m++;
		}	  
		
		if(n > 0) m++;
		printf("words: %d\n", m);
		
		s[0] = toupper(s[0]);
		printf("%s " s);
		
		return 0;
}