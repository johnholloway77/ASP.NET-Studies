/*
 Parent class for other service files (Customer Service, Gym Service, etc).

It contains methods that are common to all of the child classes.

This is an abstract class which cannot be instantated. 
 

This class should have been named "Services" or something instead of "ServicePage" since it doesn't display a GUI page, but I'm too tired to change it now. 
 * 
 * Date: 27 April 2023
 * By: John Holloway

 */

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRGFitness.Services
{
    public abstract class ServicePage
    {
        static internal MySqlConnection connection;
        static private string server;
        static private string port;
        static private string database;
        static private string uid;
        static private string password;

        public ServicePage()
        {
            Initialize();
        }

        public static void Initialize()
        {
            

            server = "10.0.0.45";
            port = "3306";
            database = "cprg211";
            uid = "CPRG211f";
            password = "CPRGp@ss1";


            string connectingString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectingString);
        }

        public static void selectAll()
        {
            CustomerServices.LoadFromDatabase();
            GymService.LoadFromDatabase();
            SessionService.LoadFromDatabase();
            StaffServices.LoadFromDatabase();
            TrainerServices.LoadFromDatabase();
        }

        //open connection to DB
        internal static bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server. Contact Adminsitrator");
                        Console.WriteLine("Error", "Cannot connect to server. Contact Adminsitrator", "Okay");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password. Please try again");
                        Console.WriteLine("Error", "Invalid username/password. Please try again", "Okay");
                        break;
                }

                return false;
            }
        }

        //close connection  to Db
        internal static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }



    }
}
