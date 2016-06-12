using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAcess;

namespace BusinessLogic
{
    public class StudentsBL : IDisposable
    {
        private IDAO<Student> _studentsDAO;

        public StudentsBL()
        {
            _studentsDAO = new StudentsDAO();
        }

        public List<Student> GetList()
        {
            return _studentsDAO.GetList().ToList<Student>();
        }

        public void Add(Student student)
        {
            _studentsDAO.Add(student);
        }

        public void Edit(Student student)
        {
            _studentsDAO.Edit(student);
        }

        public void Delete(Student student)
        {
            _studentsDAO.Delete(student);
        }
        /// <summary>
        /// Получить средний балл за весь период
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public double GetEntireAverageMark(Student student)
        {
            int count = 0;
            double sum = 0;
            foreach (var item in student.Progress)
            {
                sum += (int)item.Mark;
                count++;
            }
            return sum / count;
        }
        /// <summary>
        /// Получить средний балл за первый семестр
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public double GetFirstSemesterAverageMark(Student student)
        {
            int count = 0;
            double sum = 0;
            foreach (var item in student.Progress)
            {
                if (item.Semester == "Первый")
                {
                    sum += (int)item.Mark;
                    count++;
                }
            }
            return sum / count;
        }
        /// <summary>
        /// Получить средний балл за второй семестр
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public double GetSecondSemesterAverageMark(Student student)
        {
            int count = 0;
            double sum = 0;
            foreach (var item in student.Progress)
            {
                if (item.Semester == "Второй")
                {
                    sum += (int)item.Mark;
                    count++;
                }
            }
            return sum / count;
        }
        /// <summary>
        /// Получить общее количество пропущенных часов
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public int GetSumMissedHoursNumber(Student student)
        {
            int sum = 0;
            foreach (var item in student.Attendance)
            {
                sum += (int)item.MissedHoursNumber;
            }
            return sum;
        }
        /// <summary>
        /// Получить количество пропущенных часов за первый семестр
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public int GetFirstSemesterMissedHoursNumber(Student student)
        {
            int sum = 0;
            foreach (var item in student.Attendance)
            {
                if (item.Semester == "Первый")
                {
                    sum += (int)item.MissedHoursNumber;
                }
            }
            return sum;
        }

        /// <summary>
        /// Получить количество пропущенных часов за второй семестр
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public int GetSecondSemesterMissedHoursNumber(Student student)
        {
            int sum = 0;
            foreach (var item in student.Attendance)
            {
                if (item.Semester == "Второй")
                {
                    sum += (int)item.MissedHoursNumber;
                }
            }
            return sum;
        }

        public void Dispose()
        {
            _studentsDAO.Dispose();
        }
    }
}
