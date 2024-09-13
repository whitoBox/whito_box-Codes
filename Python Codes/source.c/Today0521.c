/*#include <stdio.h>
int main()
{
  char str[20];
  int cnt, length =0;

  scanf("%s",str);

  for (int i = 0; str[i]!='\0'; i++)
  {
    length++;
  }
  printf("\nyour chereter length:%d",length);

  return 0;
}*/
/*#include <stdio.h>
#define AL 5
int main()
{
  int s_list[AL]={5,4,1,3,2};
  int a,b,temp,sort;

  for (a = 0;a < AL-1; a++)
  {
    sort=a;
    for (int b = a+1; b < AL; b++)
    {
      if(s_list[b]<s_list[sort])
      {
        sort=b;
      }
      temp = s_list[a];
      s_list[a] = s_list[sort];
      s_list[sort]=temp;
    }
  }
  for (int i = 0; i < AL; i++)
  {
    printf("%d " ,s_list[i]);
  }
  
}*/
/*#include <stdio.h>
int main(i)
{
  int num[10002];
  for (scanf("%d %d",&num[10002],&num[10001]); i<num[10002]; i++)
  {
    scanf("%d",&num[i]);
    if(num[i]>=num[10001])
    num[i]=0;
    if(num[i]>0)
    printf("%d ",num[i]);
  }
}*/
