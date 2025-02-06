public class MyCustomer
{
    // 필드
    private string name;
    private int age;
    
    private long yearmoney;

    // 이벤트 
    public event EventHandler NameChanged;

    // 생성자 (Constructor)
    public MyCustomer()
    {
        name = string.Empty;
        age = -1;
    }

    // 속성
    public string Name
    {
        get { return this.name; }
        set 
        {
            if (this.name != value)
            {
                this.name = value;
                if (NameChanged != null)
                {
                    NameChanged(this, EventArgs.Empty);
                }
            }                
        }
    }
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public long YearMoney
    {
        get { return this.yearmoney; }
        set 
        { 
            if(value < 0)
            {
                Console.WriteLine($"음수는 안됩니다.");
            }
            else
            {
                yearmoney  = value;
            }    
        }
    }
    // 메서드
    public string GetCustomerData()
    {
        string data = string.Format("Name: {0} (Age: {1})", 
                    this.Name, this.Age);
        return data;
    }

    public void SetYearMoney(long val)
    {
        if(val < 0)
        {
            Console.WriteLine($"음수는 안됩니다.");
            
        }
        else
        {
            yearmoney  = val;
        }
    }
}