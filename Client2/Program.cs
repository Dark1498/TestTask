using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Client2.Models;

namespace Client2
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static async Task CreateWord(Word word)
        {
            await client.PostAsJsonAsync("api/words", word);
        }
        static async Task CreateUser(User user)
        {
            await client.PostAsJsonAsync("api/users", user);
        }

        static async void GetUsers()
        {
            var content = await client.GetStringAsync("https://localhost:44370/api/users");
            Console.WriteLine(content);
            
        }

        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
           
        }

        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("https://localhost:44370/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                //10 запросов на 1 задание
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Word=");
                    Word word = new Word
                    {
                        Words = Console.ReadLine(),
                    };
                    await CreateWord(word);

                }
                //10 запросов на 2 задание
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("FirstName=");
                    Console.WriteLine("MiddleName=");
                    Console.WriteLine("LastName=");
                    Console.WriteLine("Iin=");
                    Console.WriteLine("Birthday Format(YYYY,MM,DD) =");
                    User user = new User
                    {
                        
                        FirstName = Console.ReadLine(),
                        MiddleName = Console.ReadLine(),
                        LastName = Console.ReadLine(),
                        Iin = Convert.ToInt32(Console.ReadLine()),
                        Birthday = Convert.ToDateTime(Console.ReadLine()),

                    };

                    await CreateUser(user);

                }
                GetUsers();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

// LEAVE ME HERE

