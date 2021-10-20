#include <stdio.h> //scanf(), printf()
#include <math.h> // cosf(), sinf(), M_PI, sqrtf()
 
 int main()
{
		float x0, y0; 
		printf ("x0, y0: "); //координаты пушки
		scanf("%f %f", &x0, &y0);
		
		float v0, a;
		printf ("v0, a: "); // v0 - начальная скорость, a - направление (угол) 
		scanf("%f %f", &v0, &a);

		float ra = a * (float) M_PI / 180.0f; // перевод угла в радианы 
		
		float v0x = cosf(ra) * v0; // из палярной системы в декартовую
		float v0y = sinf(ra) * v0;
		
#define g 9.8f

	float d = v0y * v0y + 4.0f * g / 2.0f * y0;
	printf("d = %f\n", d);

	float t1 = (-v0y - sqrtf(d)) / (2.0f * (-g / 2.0f));
	float t2 = (-v0y + sqrtf(d)) / (2.0f * (-g / 2.0f));
	
	printf("t1 = %f, t2 = %f\n", t1, t2);

	float t = 0.0f;
	float x;
	float y;
#define eps 0.001f;
FILE *f = fopen("exam3-b.txt", "w+");
	while(1)
	{
		x = x0 + v0x * t;
		y = y0 + v0y * t - (g * t * t) / 2.0f; // формула равноускоренного движения
		
		printf("t = %f, x = %f, y = %f\n", t, x, y); 
		
		if (y <= 0.0f) break;
		
		t +=  eps;
	}
	
	
    printf("t = %f, x = %f, y = %f\n", t, x, y);
	fclose(f);
	return 0;
}