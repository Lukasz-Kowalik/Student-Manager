﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Data;
using static Database.DataBase;
using static Database.ShowGrades;

namespace Database
{

  [DBTab]
    public sealed class Grade
    {
        [DBColl(Title="Nr Indeksu Studenta",ForeignKey= "[dbo].[Students]([StudentNo])")]
        public int StudentNo { get; set; }
        [DBColl(Title ="Ocena")]
        public double Value { get; set; }
        [DBColl(Title ="Data wystawienia")]
        public DateTime Date { get; set; }
        public Grade()
        {

        }
        public Grade(double grade)
        {
           Value = grade;
        }
        public Grade(int studentNo,double value, DateTime date)
        {
            StudentNo = studentNo;
            Value = value;
            Date = date;
        }
    }
}