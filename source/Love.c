#include <stdio.h>
int main()
{
    int ac1;

    scanf("%d",&ac1);
    if(ac1%400 == 0)
    {
        printf("1");
    }
        else if(ac1%4==0)
        {
            if(ac1%100 /= 0)
            {
                printf("1");
            }
            
        }
        else
        {
            printf("0");
        }
    
    return 0;
}