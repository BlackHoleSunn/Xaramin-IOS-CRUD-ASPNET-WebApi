using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;



namespace App3.Models
{
    class UsersRepositry
    {

        public async Task<string> SaveNewUser(Users newUser)
        {
            var client = new HttpClient();

            var uri = new Uri("http://carraramarketapp.azurewebsites.net/api/users");

            var jsoncontent = JsonConvert.SerializeObject(newUser);
            var content = new StringContent(jsoncontent, Encoding.UTF8, "application/json");

          
            var result = client.PostAsync(uri, content).Result;



            return "success";


        }


        public async Task<IEnumerable<Users>> GetAllUsersRepository()
        {
            var client = new HttpClient();

            var result = await client.GetStringAsync("http://carraramarketapp.azurewebsites.net/api/users");

            // return JsonConvert.DeserializeObject<List<Users>>(result);

            return JsonConvert.DeserializeObject<List<Users>>(result);
        }



        public async Task<Users> LoadSingleUser(int userid)
        {
            var client = new HttpClient();

            var result = await client.GetStringAsync("http://carraramarketapp.azurewebsites.net/api/users/" + userid);

            // return JsonConvert.DeserializeObject<List<Users>>(result);

            return JsonConvert.DeserializeObject<Users>(result);
        }



        public async Task<string> DeleteUser(int userid)
        {


            var client = new HttpClient();

            client.BaseAddress = new Uri("http://carraramarketapp.azurewebsites.net/");


            HttpResponseMessage response = await client.DeleteAsync("api/users/" + userid);

            if (response.IsSuccessStatusCode)
            {
                Console.Write("Success");
                return "success";

            }
            else { 
                Console.Write("Error");
                return "error";

            }

        }


    }


    //interface IUsersRepository
    //{
    //    Task<IEnumerable<Users>> GetAllUsersRepository();

    //}

    //interface LoadSingle
    //{
    //    Task<Users> LoadSingleUser();

    //}



}
