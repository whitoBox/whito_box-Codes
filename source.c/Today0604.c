#include <stdio.h>
int thing1()
{
  char sa[]="Spacezone";
  char *ps="spacezone";

  printf("sa: %d\n",sa);
  printf("ps: %d\n",ps);

  for (int i = 0; i < 9; i++)
  {
    printf("sa[%d]=%c ",i,sa[i]);
    printf(" *(ps+%d):%c\n",i,*(ps+i));
  }
}
//---------------------------------------------
int thing2()
{
  int cnt,size,choice;
  char *task[]={"Desk",
                "Computer",
                "Books",
                "USB",
                "EXIT"};
  printf("chose array number (5to exit)\n");

  size =sizeof(task)/sizeof(task[0]);

  for (int i = 0; i < size; i++)
  {
    printf("%d.%s\n",i+1,task[i]);
  }
  while(1)
  {
    printf("number 1~5\n");
    scanf("%d",&choice);
    if(choice<1||choice>5)
    {
      printf("wrong number");
      continue;
    }
    else if(choice==5)break;
    else
      printf("you selected : %s\n",task[choice-1]);
  }
  return 0;
}
//-----------------------------------
void creed(char **ppc);
void target(char **ppc);
int main()
{
  char *pc;

  creed(&pc);
  printf("life quote:%s\n",pc);

  target(&pc);
  printf("life target:%s",pc);
  return 0;
}
void creed(char **ppc)
{
  *ppc="do my best";
  printf("AAAAAAAAAAAA:%s\n",ppc);
}
void target(char **ppc)
{
  *ppc="life without regret";
}