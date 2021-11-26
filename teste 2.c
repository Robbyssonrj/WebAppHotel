#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct atendente_user{
    char login[30];
    char senha[30];
} usuario; usuario u[1];

int main(){
    char login[30];
    char senha[30];

    strcpy(u[0].login, "N593FA5");
    strcpy(u[0].senha, "123");

    printf("\t\t\t********************************************************\n");
    printf("\t\t\t* * * * * * *  System Medical Service Unit * * * * * * *\n");
    printf("\t\t\t********************************************************\n");
    printf("\t\t\t********************************************************\n");
    printf("\t\t\t*   *   *  LOGIN:");
    scanf("%s", login);
    printf("\t\t\t*   *   *  SENHA:");
    scanf("%s", senha);

    if((strcmp(login,u[0].login)==0)&&(strcmp(senha,u[0].senha)==0)){
        printf("Atendente Online");
    }else{
        printf("Login ou Senha Incorreta");
    }
    return 0;

}

