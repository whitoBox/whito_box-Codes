#include <stdio.h>//전역 변수에 대한 코드
int add();
int Ga;
int Gb;
int main()
{
  Ga=10;
  Gb=20;
  int sum=0;

  sum=add();
  printf("%d",sum);
  return 0;
}

int add()
{
  int ba;
  ba = Ga+Gb;
  return ba;
}
