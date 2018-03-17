using System;
using System.Collections.Generic;

namespace Grades
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

        public string Name {
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
                        var args = new NameChangedEventArgs();
                        args.NewName = value;
                        args.OldName = Name;

                        _name = value;

                        NameChanged(this, args);
                    }
                }
            }
        }

        public List<float> grades;
        private string _name;
        public event NameChangedDelegate NameChanged;

    }
}
