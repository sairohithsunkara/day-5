using System;
 public struct Student
{
	public string name;
	public int rollno;
	public string gender;
}
	
public class student
{
	public enum Gender
	{
		female=0,male=1
	}

	public static void Main()
	{
		Student[] arr = new Student[2];
		arr[0].name="abc";
		arr[0].rollno=12;
		arr[1].name="def";
		arr[1].rollno=32;
			int c=0;
		for(int i=0;i<2;i++)
		{
			Console.WriteLine("enter gender for student: "+(i+1));
			Console.WriteLine("enter \n0.for female\n1.for male");
			c=Convert.ToInt32(Console.ReadLine());
			if(c==0)
			arr[i].gender=Gender.female.ToString();
			else if(c==1)
			arr[i].gender=Gender.male.ToString();	
		}
		Console.WriteLine("Name:\t\tRollNo\t\tGender");
		Console.WriteLine();
		for(int i=0;i<2;i++)
		{
			Console.WriteLine(arr[i].name+"\t\t\t"+arr[i].rollno+"\t\t\t"+arr[i].gender);
			Console.WriteLine();
			
		}
	
		
	}	

		}