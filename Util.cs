class Util
{
    /// <summary>
    /// 배열의 내용을 출력
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="values"></param>
    public static void PrintIntArray<T>(T[] values)
    {
        Console.Write("{");
        for (int i = 0; i < values.Length; i++)
        {
            if ( i != 0)
            {
                Console.Write(",");
            }
            Console.Write(values[i]);
        }
        Console.WriteLine("}");
    }
    /// <summary>
    /// 정수 배열의 내용을 출력 
    /// </summary>
    /// <param name="intArray">출력할 배열</param>
    public static void PrintIntArray(int[] intArray)
    {
        Console.Write("{");
        for (int i = 0; i < intArray.Length; i++)
        {
            if ( i != 0)
            {
                Console.Write(",");
            }
            Console.Write(intArray[i]);
        }
        Console.WriteLine("}");
    }
}