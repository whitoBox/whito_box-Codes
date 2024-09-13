#include <stdio.h>//동적변수 정적변수
void start();
int main()
{
  start();
  start();
  start();
  return 0;
}
void start()
{
  static int a=0;
  int b=0;

  printf("static int:%d int:%d\n",a,b);
  a++;
  b++;
}