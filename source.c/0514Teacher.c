#include <stdio.h>

#define MAX_NUMBERS 100
#define RANGE 10

void readNumbers(int numbers[],int n);
void calculateFrequency(int numbers[],int n,int frequency[]);
void printFrequency(int frequency[],int range);

int main()
{
  int N;
  printf("Enter the number of elements (up to %d):",MAX_NUMBERS);
  scanf("%d",&N);

  if(N<1 || N > MAX_NUMBERS)
  {
    printf("valid number of elements between 1 and %d.\n");
    return 1;
  }
  int numbers[N];
  readNumbers(numbers,N);

  int frequency[RANGE]={0};
  calculateFrequency(numbers,N,frequency);

  printFrequency(frequency,RANGE);
}

void readNumbers(int numbers[],int n)
{
  printf("Enter %d numbers (0~9):",n);
  for (int i = 0; i < n; i++)
  {
    scanf("%d",&numbers[i]);
    if (numbers[i]<0||numbers[i]>9)
    {
      printf("Invalid Number: %d. Please unter 0 and 9.\n",numbers[i]);
      i--;//Adjust teh inded to re enter the correct number
    }   
  }
}

void calculateFrequency(int numbers[],int n, int frequency[])
{
  for (int i = 0; i < n; i++)
  {
    frequency[numbers[i]]++;
  }
}

void printFrequency(int frequency[],int range)
{
  for (int i = 0; i < range; i++)
  {
    printf("Number %d: %d times\n",i,frequency[i]);
  }
}
