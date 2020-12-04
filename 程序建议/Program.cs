using System;

namespace 程序建议
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(new Student() { Name = "测试" });
            //person.readonlyValue = new Student();//无法对制度字段赋值（构造函数或变量初始值可以赋值）
            Console.WriteLine("Hello World!");
        }
    }
}

public class Person
{
   public readonly Student readonlyValue;
    public Person(Student student)
    {
        readonlyValue = student;
    }

    public int ID { get; set; }
}
public class Student
{
    public string Name { get; set; }
}
