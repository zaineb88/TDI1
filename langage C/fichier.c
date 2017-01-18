#include <stdio.h>

    
    
/*
int main(int argc, char *argv[])
{
    char nomfichier[21];
    int n ;
    FILE *sortie;
    printf("Entrer le nom du à créer : ");
    scanf("%s",nomfichier);
    sortie=fopen (nomfichier,"w");
    do{
                 printf("doner un entier : ");
                 scanf("%d",&n);
                 if(n)
                 {fwrite(&n, sizeof(int),1,sortie);}
                 }while(n);// n >> n!=0
  fclose(sortie);  }
}
*/
/*
#include<stdio.h>
int main(int argc, char *argv[])
{
    char nomfich[21];
    int n;
    FILE *entree;
    printf("Entrer le nom du fichier à lister : ");
    scanf("%s",nomfich);
    entree = fopen(nomfich,"r");
    while(fread(&n,sizeof(int),1,entree)&&!feof(entree))
    {printf("\n %d",n);}
    getch();
    fclose(entree);  
}
*/
#include<stdio.h>
int main(int argc, char *argv[])
{
    char nomfich[21];
    int n;
    FILE *entree;
    long num;
    printf("Entrer le nom du fichier à lister : ");
    scanf("%s",nomfich);
    entree = fopen(nomfich,"r");
    do{
           printf("numero de l'entier recherché : ");
           scanf("%1d",&num);
           if(num !=0)
           {fseek(entree,sizeof(int)*(num-1),SEEK_SET);
           fread(&n, sizeof(int),1,entree);
           printf("valeur : %d \n",n);
           }
           }while(num!=0);
           fclose(entree);
           }
    
 

