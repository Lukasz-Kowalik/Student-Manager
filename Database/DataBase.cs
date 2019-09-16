﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    internal static class DataBase
    {
        private static string DBConectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=P:\dev\Visual Studio programs\Database\Database\DataBase.mdf;Integrated Security=True";

        public static List<Student> SqlStudentSelect()
        {
            var students = new List<Student>();
            using (var connection = new SqlConnection(DBConectionString))
            {
                var cmd = connection.CreateCommand();

                cmd.CommandText = "Select [StudentNo],[FirstName],[SurName],[Faculty] FROM [P:\\DEV\\VISUAL STUDIO PROGRAMS\\DATABASE\\DATABASE\\DATABASE.MDF].[dbo].[Students]";

                cmd.CommandType = CommandType.Text;

                connection.Open();

                var res = cmd.ExecuteReader();

                while (res.Read())
                {
                    students.Add(new Student(res.GetString(2), res.GetString(1), res.GetInt32(0), res.GetString(3)));
                }
            }
            return students;
        }
    }
}