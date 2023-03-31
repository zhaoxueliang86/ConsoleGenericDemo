namespace ConsoleGenericDemo.Person
{
    /// <summary>
    /// 人员的抽象类
    /// </summary>
    public abstract class Person
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int Age { get; set; }
    }
}
