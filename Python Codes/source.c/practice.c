#include <stdio.h>
int main()
{
    int num=1,total=0;
    while (num<=10)
    {
        total+=num;
        num++;
    }
    printf("1���� 10������ �� = %d\n",total);
    printf("while���� ���� ���� num�� �� = %d",num);
    
    return 0;
}