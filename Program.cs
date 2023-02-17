using ConsoleGenericDemo;

//原型模式：对象通过请求原型对象的克隆方法来实施创建
//例：var ObjNew = Obj.Clone();

//实现：
//1、浅克隆：
//      值类型，实际数据将复制一份给新对象；
//      引用类型，复制一份引用类型的引用给新对象，也就是说新对象和原型对象的引用变量指向相同的内存地址
//2、深克隆
//      无论是值类型还是引用类型，实际数据均复制一份给新对象，真正意义上的全新的对象

//优点：
//1、性能优良，简化对象的创建过程，通过复制一个已有实例提高新实例的创建效率
//2、创建过程简单，只需要调用Clone方法就可以得到一个新的实例
//3、逃避构造函数的约束，直接在内存中拷贝，这既是优点也是缺点，需要在实际应用中去斟酌
//4、扩展性好，客户端可以针对抽象原型类进行编程，将具体原型类写在配置文件中，增加或减少产品类不会影响原有系统

//缺点：
//1、违背开闭原则，克隆方法位于类的内部
//2、多重嵌套引用时，实现对象的深克隆较为复杂


Console.WriteLine(string.Empty.PadLeft(80, '-'));

//New一个实例
var s1 = new Subject()
{
    Semester = 2021,   //学期
    Name = "语文",
    SchoolReport = new SchoolReport() { Peacetime = 80, FinalExam = 85 }
};

Console.WriteLine($"【s1】  学期：{s1.Semester}  科目：{s1.Name}  " +
  $"平时成绩：{s1.SchoolReport.Peacetime}  期末成绩：{s1.SchoolReport.FinalExam}   " +
  $"实例化之后");

Console.WriteLine(string.Empty.PadLeft(80, '-'));

var s2 = s1.DeepClone();
Console.WriteLine($"【s1】  学期：{s1.Semester}  科目：{s1.Name}  " +
  $"平时成绩：{s1.SchoolReport.Peacetime}  期末成绩：{s1.SchoolReport.FinalExam}   " +
  $"Clone之后");
Console.WriteLine($"【s2】  学期：{s2.Semester}  科目：{s2.Name}  " +
  $"平时成绩：{s2.SchoolReport.Peacetime}  期末成绩：{s2.SchoolReport.FinalExam}   " +
  $"Clone之后");

Console.WriteLine(string.Empty.PadLeft(80, '-'));

s2.Semester = 2022;
Console.WriteLine($"【s1】  学期：{s1.Semester}  科目：{s1.Name}  " +
  $"平时成绩：{s1.SchoolReport.Peacetime}  期末成绩：{s1.SchoolReport.FinalExam}   " +
  $"s2.学期改为2022 之后");
Console.WriteLine($"【s2】  学期：{s2.Semester}  科目：{s2.Name}  " +
  $"平时成绩：{s2.SchoolReport.Peacetime}  期末成绩：{s2.SchoolReport.FinalExam}   " +
  $"s2.学期改为2022 之后");

Console.WriteLine(string.Empty.PadLeft(80, '-'));

s2.Name = "数学";
Console.WriteLine($"【s1】  学期：{s1.Semester}  科目：{s1.Name}  " +
  $"平时成绩：{s1.SchoolReport.Peacetime}  期末成绩：{s1.SchoolReport.FinalExam}   " +
  $"s2.学科改数学 之后");
Console.WriteLine($"【s2】  学期：{s2.Semester}  科目：{s2.Name}  " +
  $"平时成绩：{s2.SchoolReport.Peacetime}  期末成绩：{s2.SchoolReport.FinalExam}   " +
  $"s2.学科改数学 之后");

Console.WriteLine(string.Empty.PadLeft(80, '-'));

s2.SchoolReport.Peacetime = 60;
s2.SchoolReport.FinalExam = 70;
Console.WriteLine($"【s1】  学期：{s1.Semester}  科目：{s1.Name}  " +
  $"平时成绩：{s1.SchoolReport.Peacetime}  期末成绩：{s1.SchoolReport.FinalExam}   " +
  $"s2修改成绩 之后");
Console.WriteLine($"【s2】  学期：{s2.Semester}  科目：{s2.Name}  " +
  $"平时成绩：{s2.SchoolReport.Peacetime}  期末成绩：{s2.SchoolReport.FinalExam}   " +
  $"s2修改成绩 之后");

Console.WriteLine(string.Empty.PadLeft(80, '-'));

Console.ReadKey();
