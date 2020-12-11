using System;
using System.Collections.Generic;
using System.Linq;

namespace 程序建议
{
    class Program
    {
        int TimesCalled = 0;
        void Display(object state)
        {
            Console.WriteLine("{0} {1} keep running.", (string)state, ++TimesCalled);
        }
        static void Main(string[] args)
        {
            //Readonly
            Person person = new Person(new Student() { Name = "测试" });
            //person.readonlyValue = new Student();//无法对制度字段赋值（构造函数或变量初始值可以赋值）
            //引用本身不可变，引用所指的实例的值是可以改变的
            person.readonlyValue.Name = "测试2";
            //Console.WriteLine(Week.Monday);

            List<Student> students = new List<Student>(3)
            {
                new Student{ID=3,Name="33"},
                new Student{ID=2,Name="33"},
                new Student{ID=4,Name="33"},
                new Student{ID=1,Name="33"}
            };
            //students.ForEach(s => Console.WriteLine($"ID:{s.ID},Name:{s.Name}"));
            //Console.WriteLine(students.Count);
            //Console.WriteLine(students.Capacity);
            students.TrimExcess();//删除额外的容量
            //Console.WriteLine(students.Count);
            //Console.WriteLine(students.Capacity);

            var result = new Student()
            {
                ID = 1,
                Data = new List<Data>
                {
                    new Data{Code=1},
                    new Data{Code=2},
                    new Data{Code=3}
                }
            };
            var result2 = new Student()
            {
                ID = 1,
                Data = new List<Data>
                {
                    new Data{Code=1},
                    new Data{Code=2},
                    new Data{Code=4}
                }
            };
            var sss = result.Data.Intersect(result2.Data).ToList();

            Program p = new Program();
            //2秒后第一次调用，每1秒调用一次
            System.Threading.Timer myTimer = new System.Threading.Timer(p.Display, "Processing timer event", 2000, 1000);
            // 第一个参数是：回调方法，表示要定时执行的方法，第二个参数是：回调方法要使用的信息的对象，或者为空引用，第三个参数是：调用 callback 之前延迟的时间量（以毫秒为单位），指定 Timeout.Infinite 以防止计时器开始计时。指定零 (0) 以立即启动计时器。第四个参数是：定时的时间时隔，以毫秒为单位

            Console.WriteLine("Timer started.");
            Console.ReadLine();
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

    public List<Data> Data2 { get; set; }
}
public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }

    public List<Data> Data { get; set; }
}

public enum Week
{
    Monday = 0
}

public class Data
{
    public int Code { get; set; }
}
