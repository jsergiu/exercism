using System;
using System.Collections.Generic;
using System.Linq;

public class School
{

	private class Student
	{
		public string name;
		public int grade;

		public Student(string name, int grade)
		{
			this.name = name;
			this.grade = grade;
		}
	}

	private List<Student> roaster = new List<Student>();

    public void Add(string student, int grade)
    {
		roaster.Add(new Student(student, grade));
    }

    public IEnumerable<string> Roster()
    {
		List<string> names = (from s in roaster
							  orderby s.grade, s.name
							  select s.name).ToList();
		return names;
	}

    public IEnumerable<string> Grade(int grade)
    {
		List<string> names = (from s in roaster
							   where s.grade == grade
							   orderby s.grade, s.name
							   select s.name).ToList();
		return names;
	}
}