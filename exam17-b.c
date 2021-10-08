#include <stdio.h>
#include <string.h> 
#include <ctype.h>

int main()
{
		char s[256];
		char l[256] ;  
		fgets(s, 256, stdin);
		
		
		char *p = strchr(s, '\n'); 
		if (p != NULL) p[0] = '\0';
		
		size_t n = strlen(s);
		
		printf("len: %ld\n", n);
		s[0] = toupper(s[0]);
		int m = 0;
		for (int i = 0; i < n; i++)
		{
			 if (s[i] == ' ') 
			 {
				s[i + 1] = toupper(s[i + 1]);
			 m++;
			 }
					 
		}	  
		
		if(n > 0) m++;
		printf("words: %d\n", m);		
		printf("%s\n", &s);
		
		
				
		return 0;
}