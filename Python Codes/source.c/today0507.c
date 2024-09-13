#include <stdio.h>//매개변수의 이용에 대한 코드

int fact(int n);

int main()
{
  int num,result;
  scanf("%d",&num);

  result=fact(num);
  printf("%d",result);
}

int fact(int n)
{
  if(n<=1)
  {
    return 1;
  }
  else
  {
    return (n + fact(n-1));
  }
}
