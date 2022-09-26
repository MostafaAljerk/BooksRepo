using Book_Data;
using Book_Domain;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Book_AppMain
{
    public class AddUser
    {
        public void adduser()
        {
            string file = File.ReadAllText("user.json");
            var Contents = JsonSerializer.Deserialize<List<User>>(file);
            var Context = new BookDbContext();
            
               // Console.WriteLine(file);
                Context.Users.AddRange(Contents);
               // Context.SaveChanges();
                //Console.WriteLine("save");
            }
        
        public void viewuser()

        {
            
          string file = File.ReadAllText("user.json");
           //var Contents = JsonSerializer.Deserialize<List<User>>(file);
            var Context = new BookDbContext();
            
               // Console.WriteLine(file);
            
            Console.WriteLine("Add user From Json? Y/N");
            var file1=Console.ReadLine();
            if (file1=="y")
            {
                Console.WriteLine(file);
            }
            else if (file1 == "n")
            {
                Console.WriteLine("UserName :");
                string userName=Console.ReadLine();
                Console.WriteLine("PassWord :");
                string passWord = Console.ReadLine();
                var test = Context.Users
                    .Where(u => u.UserName == userName && u.PassWord == passWord)
                    .Select(u => new {u. UserName, u.PassWord });
                foreach (var item in test)
                {
                    if (item.UserName.Equals(userName)
                        && item.PassWord.Equals(passWord))
                    {

                      
                          
                        Console.WriteLine("Date Is True");
                    }
                        

                    
                }

            }
        }

        }
    }
