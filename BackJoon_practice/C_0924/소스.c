#include <stdio.h>

// 명령어를 하나로 묶어주는 기능이 있습니다.
// 함수

// returntype 함수명(매개변수){
// 명령어 나열.
//}

// 함수안에 명령어를 처리하고 결과값이 없는 경우에는 void라고 지정하시면 됩니다.


void PrintMonster() {
    printf("Monster is World!!\n");
    printf("Monster is World!!\n");
    printf("Monster is World!!\n");
    printf("Monster is World!!\n");
    printf("Monster is World!!\n");
    printf("Monster is World!!\n");
    printf("Monster is World!!\n");
    printf("Monster is World!!\n");
    printf("Monster is World!!\n");
    printf("Monster is World!!\n");
}

// 함수를 사용하면
// 1. 재사용성
// 2. 모듈성
// 3. 가독성( 소스코드 분석하기 쉬워진다.)
void PrintMonsterNum(int count) {
    for (int i = 0; i < count; i++) {
        printf("Monster is World!!\n");
    }
}

// main.함수는 특별한 용도로 사용됩니다.
// C언어로 만들어진 프로그램은 main함수에서부터 프로그램이 시작됩니다.
// 그래서 main함수를 진입점 함수라고 합니다.
int main() {

    PrintMonsterNum(10);
    ///.......


    PrintMonster();
    //.....

    PrintMonster();




    return 0;
}