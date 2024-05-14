#include <stdio.h>
float calculate(float i)
{
  return i*i*3.14;
}

int main()
{
  int size;
  scanf("%d",&size);
  printf("%.2f",calculate(size));
  return 0;
}

