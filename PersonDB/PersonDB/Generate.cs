﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace PersonDB
{
    class Generate
    {
        string strConn = "Data Source=BA2H-PC\\SQL;Initial Catalog=PersonDB;Integrated Security=True";
        SqlConnection conn;

        public void CreateTables()
        {
            //strConn = "Data Source=BA2H-PC\\SQL;Initial Catalog=PersonDB;Integrated Security=True";
            
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();

                string cteateTblPerson = File.ReadAllText(@"D:\ШАГ\0 Repository\SQL\PersonDB\PersonDB\query\Person.sql");
                    
                SqlCommand commandPerson = new SqlCommand(cteateTblPerson);
                commandPerson.Connection = conn;
                commandPerson.ExecuteNonQuery();
                Console.WriteLine("Query <<Person.sql>> completed!");

                string cteateTblCountry = File.ReadAllText(@"D:\ШАГ\0 Repository\SQL\PersonDB\PersonDB\query\Country.sql");
                SqlCommand commandCountry = new SqlCommand(cteateTblCountry);
                commandCountry.Connection = conn;
                commandCountry.ExecuteNonQuery();
                Console.WriteLine("Query <<Country.sql>> completed!");

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That\'s no good\n\n" + ex.Message);
            }
        }
        public void GeneratePerson()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            Random rnd = new Random();
            List<Person> listPersons = new List<Person>();
            var person = new Faker<Person>("uk")
                .RuleFor(u => u.Surname, f => f.Name.LastName())
                .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(u => u.Age, f => f.Random.Int(20, 50));

            for (int i = 0; i < 10; i++)
            {
                listPersons.Add(person.Generate());
            }

            //foreach (var item in listPersons)
            //{
            //    Console.WriteLine($"{item.Surname,-12} тел. {item.Phone,-15}  вік - {item.Age,-2}р.");
            //}
            
            string deleteTable = "DELETE FROM Person";
            SqlCommand commandDel = new SqlCommand(deleteTable, conn);
            commandDel.ExecuteNonQuery();

            foreach (var item in listPersons)
            {
                string fill = "INSERT INTO [Person] (Surname, Age, Phone) " +
                    "VALUES (N'" + item.Surname + "','" + item.Age + "','" + item.Phone + "')";
                SqlCommand commandFill = new SqlCommand(fill, conn);
                commandFill.ExecuteNonQuery();
            }
            conn.Close();
        }
        
        public void GenerateCountry()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            List<Country> listCountries = new List<Country>();
            var country = new Faker<Country>("uk")
                .RuleFor(u => u.Title, f => f.Address.Country())
                .RuleFor(u => u.VVP, f => f.Random.Int(1000, 130000));
            for (int i = 0; i < 10; i++)
            {
                listCountries.Add(country.Generate());
            }

            //foreach (var item in listCountries)
            //{
            //    Console.WriteLine($"{item.Title,20}  ВВП = {item.VVP,-6} USD");
            //}

            string deleteTable = "DELETE FROM Country";
            SqlCommand commandDel = new SqlCommand(deleteTable, conn);
            commandDel.ExecuteNonQuery();

            foreach (var item in listCountries)
            {
                string fill = "INSERT INTO [Country] (Title, VVP) " +
                    "VALUES (N'" + item.Title + "','" + item.VVP + "')";
                SqlCommand commandFill = new SqlCommand(fill, conn);
                commandFill.ExecuteNonQuery();
            }

            conn.Close();
        }



    }
}
