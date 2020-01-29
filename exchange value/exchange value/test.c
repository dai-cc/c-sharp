//给定两个整形变量的值，将两个值的内容进行交换。
#include<stdio.h>
void main()
{
	int a,b,c;
	a = 10;
	b = 20;
	c = a;
	a = b;
	b = c;
	printf("%d %d\n",a,b);
}
