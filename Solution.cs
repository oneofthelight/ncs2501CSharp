using System.Runtime.Serialization;

class Solution
{   
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