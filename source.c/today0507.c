#include <stdio.h>

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