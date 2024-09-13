#include <stdio.h>
int main()
{
    int num=1,total=0;
    while (num<=10)
    {
        total+=num;
        num++;
    }
    printf("1부터 10까지의 합 = %d\n",total);
    printf("while문이 끝난 후의 num의 값 = %d",num);
    
    return 0;
}