using PersonWebApi.Model;

namespace PersonWebApi.Data
{
    public class DatabaseContext
    {
        private readonly IConfiguration m_Configuration;
        public  List<Person> Person { get; set; }


        public DatabaseContext(IConfiguration configuration) 
        {
            m_Configuration = configuration;
            Person = GetPeopleDatas();
        }


        public List<Person> GetPeopleDatas() 
        {

            //Use m_Configuration if you want to access database to get datas
            //var connectionString = m_Configuration.GetValue<string>("ConnectionString");

            return new List<Person>
            {
                new Person {  FirstName = "Jack", SurName = "AAA" },
                new Person { FirstName = "Yasar", SurName = "BBBB" },
                new Person { FirstName = "Ozmen", SurName = "CCC" },
                new Person { FirstName = "XXXXX", SurName = "DDDD" },
                new Person { FirstName = "YYYY", SurName = "EEEE" }
            };
        }


    }
}
