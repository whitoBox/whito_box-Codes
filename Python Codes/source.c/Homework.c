/*문제. 
James는 영문장의 각각 단의 들의 대문자는 알파벳에서 3칸뒤에 있는 문자로,
소문자는 2칸뒤에 있는 문자로 밀려 작성하며 암호화된 쪽지를 친구들과 자주 주고 받는 놀이를 한다.
James친구들의 암호화 방법을 사용하여 문장을 암호화 하고, 암호화 된 문장을 해독도 해주는 코드를 작성하시오.

암호화 예시
입력 : "abc" > 출력 : "cde"
입력 : "xyz" > 출력 : " zab" 
입력 : "ABC" > 출력 : "DEF"
입력 : "XYZ" > 출력 : "ABC"
( z 다음은 a로 돌아간다)

해독 예시:
입력 : "cde" > 출력 : "abc"
입력 : "zab" > 출력 : " xyz" 
입력 : "DEF" > 출력 : "ABC"
입력 : "ABC" > 출력 : "XYZ"

[첫줄]
코드를 실행하고 1을 입력하면 암호화 작업을 하며,
2를 입력하면 해독 작업을 한다.
(그 외 값을 입력 하면 "unknown"을 출력하고 프로그램을 종료한다)

[둘째줄]
암호화/해독 할 문자열을 입력 받는다.
(입력은 띄어쓰기가 없는 영어 문자열만 입력 받으며 최대는 100자로 제한한다.)
(영문외 문자가 입력시 "unknown character found"를 출력하며 프로그램이 끝난다.")

[셋째줄]
암호화/해독 한 문장을 출력 한다.

(프로그램 마무리) */
#include <stdio.h>
void main()
{
    char msg[100] = {0};
    int i=0,j,k=0;

    printf("encryp 1,decrypt 2 \n:");
    scanf("%d",&j);

    while(1)
    {
        if(j==1)//암호화
        {
            printf("ecrept write:");
            scanf("%s",&msg);

            for(int i=0;msg[i]!='\0';i++) //이상한 문자 감지하는 부분
            {   
                if(!(((msg[i]>=65)&&(msg[i]<=90))||((msg[i]>=97)&&(msg[i]<=122))))
                {
                    k = 1;
                    break;
                }
            }

            if(k == 1)
            {
                break;
            }

            for(;msg[i]!='\0';i++) //암호화 하는 부분
            {
                if(msg[i]<=90)
                {
                    msg[i] = msg[i] + 3;                            
                    if (msg[i]>90) //대문자 Z넘어 갔을때 A로 돌아오는 코드
                    {
                        msg[i] = msg[i] - 26;
                    }
                    
                }
                else if (msg[i]>=97)
                {
                    msg[i] = msg[i] + 2;            
                    if (msg[i]>122) //소문자 z넘어 갔을때 a로 돌아오는 코드
                    {
                        msg[i] = msg[i] - 26;
                    }
                                    
                }
                printf("%c",msg[i]);                
            }
        break;
        }

        else if(j==2)//해독
        {
            printf("write:");
            scanf("%s",&msg);

            for(int i=0;msg[i]!='\0';i++) //이상한 문자 감지하는 부분
            { 
                if(!(((msg[i]>=65)&&(msg[i]<=90))||((msg[i]>=97)&&(msg[i]<=122))))
                {
                    k = 1;
                    break;
                }
            }

            if(k == 1)
            {
                break;
            }

            for(;msg[i]!='\0';i++) //해독 하는 부분
            {
                if(msg[i]<=90)
                {
                    msg[i] = msg[i] - 3;            
                    if (msg[i]<65) //대문자 Z넘어 갔을때 A로 돌아오는 코드
                    {
                        msg[i] = msg[i] + 26;
                    }
                }
                else if (msg[i]>=97)
                {
                    msg[i] = msg[i] - 2;            
                    if (msg[i]<97) //소문자 z넘어 갔을때 a로 돌아오는 코드
                    {
                        msg[i] = msg[i] + 26;
                    }
                }
                printf("%c",msg[i]);                
            }
        break;
        }
        
        else //처음에 1,2외 다른 값 입력했을때
        {
        printf("unknown");
        break;
        }
    }
    if(k==1) // 암호화/해독 입력 구간에서 영문 외 문자를 입력했을때 나오는 출력물
    {
        printf("unknown character found");
    }       
}
