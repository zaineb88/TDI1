#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[])
{
    int k,i,j,M[4][4],M2[4][4],M3[4][4];
  for(i=0;i<3;i++)
  { for(j=0;j<3;j++)
  {printf("donner la valeur de M[%d][%d]",i,j);
  scanf("%d",&M[i][j]);
}
}
for(i=0;i<3;i++)
  { for(j=0;j<3;j++)
  {printf("donner la valeur de M2[%d][%d]",i,j);
  scanf("%d",&M2[i][j]);
}
}
for(i=0;i<3;i++)
  { for(j=0;j<3;j++)
  { M[i][j]=0;
  for(k=0;k<3;k++)
  { M3[i][j]=M3[i][j]+M[i][j]*M2[i][j];
}}}
for(i=0;i<3;i++)
{for(j=0;j<3;j++)
{printf(" %d ",M3[i][j]);
}}
  system("PAUSE");	
  return 0;
}
