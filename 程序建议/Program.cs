using System;

namespace 程序建议
{
    class Program
    {
        static void Main(string[] args)
        {
            //Readonly
            Person person = new Person(new Student() { Name = "测试" });
            //person.readonlyValue = new Student();//无法对制度字段赋值（构造函数或变量初始值可以赋值）
            //引用本身不可变，引用所指的实例的值是可以改变的
            person.readonlyValue.Name = "测试2";
            Console.WriteLine(Week.Monday);
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

public enum Week
{
    Monday=0
}
