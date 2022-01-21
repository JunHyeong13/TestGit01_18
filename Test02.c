// #include<stdio.h>

// int main()
// {
//     int C = 0;
//     scanf("%d", &C);
//     for(int i = 0; i < C; i++)
//     {
//         int N, sum, count = 0;
//         double avg = 0.f;
//         scanf("%d",&N);
//         int TestScore[] = {0, };
//         for(int j = 1; j < N; j++)
//         {
//             scanf("%d", &TestScore[j]);
//             sum += TestScore[j];
//         }
//         avg = sum/N;
//         for(int k = 0; k < N; k++)
//         {
//             if(avg < TestScore[k])
//             {
//                 count++;
//             }
//         }
//         printf("%.3f\n", (float)avg/N * 100);git got
//     }
//     return 0;
// }



#include<stdio.h>
int main(){
    int n;
    scanf("%d", &n);
    for(int i  = 0; i < n; i++)
    {
        int num, sum = 0,count = 0;
        double avg;
        scanf("%d", &num);
        int arr[1001];
        for(int j = 0; j < num; j ++)
        {
            scanf("%d", &arr[j]);
            sum+=arr[j];
        }
        avg = sum/num;        
        for(int k = 0; k < num; k ++)
            if(avg < arr[k])
                count++;
        printf("%.3f%%\n", (float)count/num*100);
    }
}