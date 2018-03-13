using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string ShowGrades()
        {
            string gradeChain = "";

            foreach (float grade in grades) {
                gradeChain += grade.ToString() + "\n";
            }

            return gradeChain;
        }

        public float CalculateAverage()
        {
            float sum = 0;
            var grades = this.grades;
            foreach (float grade in grades)
            {
                sum += grade;
            }

            return sum / grades.Count;
        }

        public string name {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        _name = value;
                        nameChanged(value);
                    }
                }
            }
        }

        public List<float> grades;
        private string _name;
        public NameDelegate nameChanged;

    }
}
