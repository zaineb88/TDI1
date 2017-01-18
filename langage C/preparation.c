#include<stdio.h>
#include<stdlib.h>
/* Question 1 */

int pp (int n)
{int i;

for(i=2;i<n;i++)
{if (i%2==0)
{return 0;}
else{return 1;}
}

int main()
{
    int i,n;
    printf("entre n");
    scanf("%d",&n);
    for(i=2;i<n;i++)
    {
    if(pp(i)==1)
    printf("%d",i);
    }
}

system("pause");
return 0;
}
