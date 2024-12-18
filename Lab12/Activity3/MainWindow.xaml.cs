using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace StudentScoreApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Query and Display Students who scored >= 90 in their first exam
            var topStudents = Students
                .Where(s => s.Scores[0] >= 90)
                .ToList();

            StudentsListBox.ItemsSource = topStudents;
        }

        // Define Grade Levels Enum
        protected enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear };

        // Student class with properties
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }
            public List<int> Scores { get; set; }
        }

        // Static list of students
        protected static List<Student> Students = new List<Student>
        {
            new Student { FirstName = "Terry", LastName = "Adams", ID = 120, Scores = new List<int> { 99, 82, 81, 79 }},
            new Student { FirstName = "Fadi", LastName = "Fakhouri", ID = 116, Scores = new List<int> { 99, 86, 90, 94 }},
            new Student { FirstName = "Hanying", LastName = "Feng", ID = 117, Scores = new List<int> { 93, 92, 80, 87 }},
            new Student { FirstName = "Cesar", LastName = "Garcia", ID = 114, Scores = new List<int> { 97, 89, 85, 82 }},
            new Student { FirstName = "Debra", LastName = "Garcia", ID = 115, Scores = new List<int> { 35, 72, 91, 70 }},
            new Student { FirstName = "Hugo", LastName = "Garcia", ID = 118, Scores = new List<int> { 92, 90, 83, 78 }},
            new Student { FirstName = "Sven", LastName = "Mortensen", ID = 113, Scores = new List<int> { 88, 94, 65, 91 }},
            new Student { FirstName = "Claire", LastName = "O'Donnell", ID = 112, Scores = new List<int> { 75, 84, 91, 39 }},
            new Student { FirstName = "Svetlana", LastName = "Omelchenko", ID = 111, Scores = new List<int> { 97, 92, 81, 60 }},
            new Student { FirstName = "Lance", LastName = "Tucker", ID = 119, Scores = new List<int> { 68, 79, 88, 92 }},
            new Student { FirstName = "Michael", LastName = "Tucker", ID = 122, Scores = new List<int> { 94, 92, 91, 91 }},
            new Student { FirstName = "Eugene", LastName = "Zabokritski", ID = 121, Scores = new List<int> { 96, 85, 91, 60 }},
        };
    }
}
