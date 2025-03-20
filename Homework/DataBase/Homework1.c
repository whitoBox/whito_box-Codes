#include <stdio.h>
void main(){
    FILE *inf, *ouf;
    int num1, num2 ,num3, num4;

    inf = fopen("in.txt","r");
    ouf = fopen("out.txt","w");

    int total = 0;
    float avr = 0;
    fprintf(ouf, "\t\t\t\t\t\t\t중간 고사 성적 일람표\n"
                 "===============================================\n"
                 "  학번    국어    영어    수학    총점    평균\n"
                 "===============================================\n");
    while(fscanf(inf, "%d %d %d %d",&num1, &num2, &num3, &num4)== 4){
        total = num2+ num3+ num4;
        avr = num2+num3+num4/3;
        fprintf(ouf,"%-8d\t %d\t\t\t%d   \t\t%d    \t%d \t%.1f\n",num1 ,num2, num3, num4, total, avr);
    }
    fprintf(ouf, "===============================================\n");
    fclose(inf);
    fclose(ouf);
}