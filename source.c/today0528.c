#include <stdio.h>
int today1()
{
  int a=8;
  int *pa=NULL;

  pa=&a;

  float b=3.75;
  float *pb=&b;

  printf("value of a:%u\n",a);
  printf("address of a:%u\n",&a);
  printf("holding address of pointer pa:%u\n",pa);

  printf("vlaue of b :%.2f\n",b);
  printf("address of b:%u\n",&b);
  printf("holding address of poiter pb:%u\n",pb);

  printf("address of NULL:%u\n",NULL);
  
  *pa=50;
  printf("a:%u",a);
  return 0;
}
int main()
{
  int a[10]={10,20,30,40,50,60,70,80,90};
  int *pi;
  pi = a;
  printf("address stored in pi = %d\n",pi);
  printf("*pi++ = %d\n",*pi++);
  printf("after address of *pi++:%d\n",pi);
  printf("(*pi)++ = %d \n",(*pi)++);
  printf("*pi = %d \n",*pi);
  
  printf("*++pi = %d\n",*++pi);
  printf("++*p = %d",++*pi);
}