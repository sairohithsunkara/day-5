

using System;
public struct Student {
    public string sname;
    public int sage;
    public int sno;
}
class HelloWorld {
  static void Main() {
    Student s1;
    s1.sname="Ram";
    s1.sage=20;
    s1.sno=12345;
    Console.WriteLine(s1.sname+" "+s1.sage+" "+s1.sno);
  }
}
