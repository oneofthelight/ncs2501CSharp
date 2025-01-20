using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

class Solution
{   
    /// <summary>
    /// 피자 나눠먹기 (3)
    /// </summary>
    /// <param name="slice"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int solution0120(int slice, int n)
    {
        int answer = 0;
        //for문 반복
        for (int i = 1; i <= n; i += slice)
        {
            // 한판 추가
            answer++;
        }
        return answer;

        /*
        int answer = 0;
        while(slice * answer < n)
        {
            answer++;
        }
        return answer;
        */
    }

    public int[] solution01172(int[] num_list)
    {
        int[] answer = new int[2];
        foreach (var item in num_list)
        {
            if (item % 2 == 0)
            {
                answer[0]++;
            }
            else
            {
                answer[1]++;
            }
        }
        return answer;
    }

    public int solution0117(int[] array, int height)
    {
        int answer = 0;
        //배열 크기만큼 반복
        /*for (int i = 0; i < array.Length; i++) {
            // 머쓱이 키와 비교
            if ( array[i] > height)
                {
                // 크면 결과값 + 1
                answer++;
                }
        }*/
        // foreach
        foreach (var item in array)
        {
            if (item > height)
            {
                answer++;
            }
        }

        // 결과값 리턴
        return answer;
    }
  
    /// <summary>
    /// 양꼬치
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int solution01142(int n, int k)
    {
        int answer = 0;
        int ser = n/10;
        answer = n * 12000 + (k * 2000 - ser * 2000) ;
        return answer;
    }

    /// <summary>
    /// 짝수의 합
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int solution0114(int n)
    {
        //계산된 값을 저장할 변수를 준비한다.
        int answer = 0;
        // n까지 반복한다
        for (int i = 1 ; i <= n ; i++)
            //짝수인가?
            if (i % 2 == 0)
                {
                    //짝수면 변수에 계산
                    answer += i;
                }
        //계산된 최종값을 리턴한다
        return answer;
    }
    /// <summary>
    /// 숫자 비교하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int solution0113(int num1, int num2)
    {
        int answer = 0;
        if (num1 == num2)
        {
            answer = 1;
        }
        else 
        {
            answer = -1;
        }
        return answer;
        //다른풀이 1
        /*int answer = -1;
        if (num1 != num2) answer = 1;
        return answer;*/
        
        //다른풀이 2
        /*if (num1 == num2) return 1;  
        return -1;*/

    }
    /// <summary>
    /// 나이 출력
    /// </summary>
    /// <param name="age">2022년도의 나이</param>
    /// <returns>출생연도</returns>
    public int solution01102(int age)
    {
        int answer = -1;
        answer = 2022 - age + 1;
        return answer;
    }
    /// <summary>
    /// 나머지 구하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int solution0110(int num1, int num2)
    {
        // 정상적인 계산으로 나올 수 없는 값을 기본값으로 해 준다.
        int answer = -1;
        answer = num1 % num2;
        return answer;

    }

    /// <summary>
    /// 두수의 차
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int solution0109(int num1, int num2)
    {
        
        return num1 - num2;
        
        //int anything = num1 - num2;
        //return anything;

        //int anything;
        //anything = num1 - num2;
        //return anything;
    }
    public int solution0108(int num1, int num2) {
        int answer = 0;
        answer = num1 * num2;
        return answer;
    }
}