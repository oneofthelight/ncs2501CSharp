class Solution
{
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