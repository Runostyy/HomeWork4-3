using System;

namespace FacultyDepartment
{
    public class Faculty
    {
        public string FacultyName { get; set; } // Назва факультету

        // Два екземпляри класу Department
        Department department1 = new Department();
        Department department2 = new Department();

        // Метод для встановлення даних для кафедр і виклику їх методів
        public void SetDepartmentsInfo()
        {
            // Встановлення інформації для кафедри 1
            department1.SetDepartmentName("Комп'ютерні науки та ІПЗ");
            department1.SetTeacherCount(10);

            department1[0] = "Програмування";
            department1[1] = "Алгоритми та структури даних";
            department1[2] = "Комп'ютерні мережі";

            // Встановлення інформації для кафедри 2
            department2.SetDepartmentName("Вища математика");
            department2.SetTeacherCount(5);

            department2[0] = "Математичний аналіз";
            department2[1] = "Дискретна математика";
            department2[2] = "Теорія ймовірностей";

            // Виклик методів для виведення інформації про кафедри
            Console.WriteLine($"Факультет: {FacultyName}");
            department1.DisplayDepartmentInfo();
            department1.DisplayDisciplines();
            Console.WriteLine();
            department2.DisplayDepartmentInfo();
            department2.DisplayDisciplines();
        }
    }

    // Частковий клас Department (перша частина)
    public partial class Department
    {
        private string departmentName; // Назва кафедри
        private int teacherCount; // Кількість викладачів

        // Метод для встановлення назви кафедри
        public void SetDepartmentName(string name)
        {
            departmentName = name;
        }

        // Метод для введення кількості викладачів
        public void SetTeacherCount(int count)
        {
            teacherCount = count;
        }

        // Виведення інформації про кафедру
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Кафедра: {departmentName}, Викладачів: {teacherCount}");
        }
    }

    // Частковий клас Department (друга частина)
    public partial class Department
    {
        private string[] disciplines = new string[5]; // Масив дисциплін (до 5 дисциплін)

        // Індексатор для встановлення дисциплін кафедри
        public string this[int index]
        {
            get { return disciplines[index]; }
            set { disciplines[index] = value; }
        }

        // Метод для виведення дисциплін кафедри
        public void DisplayDisciplines()
        {
            Console.WriteLine($"Дисципліни кафедри {departmentName}:");
            for (int i = 0; i < disciplines.Length; i++)
            {
                if (!string.IsNullOrEmpty(disciplines[i]))
                {
                    Console.WriteLine($"- {disciplines[i]}");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення екземпляра класу Faculty
            Faculty faculty = new Faculty
            {
                FacultyName = "Комп'ютерних наук"
            };

            // Виклик методу для встановлення та виведення інформації про кафедри
            faculty.SetDepartmentsInfo();

            Console.ReadKey();
        }
    }
}
