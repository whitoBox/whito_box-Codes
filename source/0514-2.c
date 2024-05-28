#include <stdio.h>
#define CNT 9

int array_1(int a[])
{
  for (int i = 0; i < CNT; i++)
  {
    a[i]+=1;
  }
}
int main()
{
  int a[10]={1,2,3,4,5,6,7,8,9};
  printf("before\n");
  for (int i = 0; i < CNT; i++)
  {
    printf("%d ",a[i]);
  }

  array_1(a);
  printf("\nafter\n");
  for (int i = 0; i < CNT; i++)
  {
    printf("%d ",a[i]);
  }
  

}
