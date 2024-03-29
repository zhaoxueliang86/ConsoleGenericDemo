﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGenericDemo
{
    public class Subject
    {
        /// <summary>
        /// 学期
        /// </summary>
        public int Semester { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 成绩
        /// </summary>
        public SchoolReport SchoolReport { get; set; } = new();

        /// <summary>
        /// 浅克隆
        /// </summary>
        /// <returns></returns>
        public Subject Clone()
        {
            return (Subject)MemberwiseClone();
        }

        /// <summary>
        /// 深克隆
        /// </summary>
        /// <returns></returns>
        public Subject DeepClone()
        {
            var subject = (Subject)MemberwiseClone();
            subject.SchoolReport = subject.SchoolReport.Clone();
            return subject;
        }
    }

    /// <summary>
    /// 学习成绩
    /// </summary>
    public class SchoolReport
    {
        /// <summary>
        /// 平时成绩
        /// </summary>
        public int Peacetime { get; set; }
        /// <summary>
        /// 期末成绩
        /// </summary>
        public int FinalExam { get; set; }

        public SchoolReport Clone()
        {
            return (SchoolReport)MemberwiseClone();
        }
    }

    public class demo
    {
        private System.Timers.Timer timer = new(2000);
        public demo()
        {
            Console.WriteLine($"{DateTime.Now}：构造函数");
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine($"{DateTime.Now}：Timer_Elapsed");
        }

        public void reset()
        {
            timer.Stop();
            Console.WriteLine($"{DateTime.Now}：Reset");
            timer.Start();
        }
    }
}
