
using System.Linq.Expressions;
using MySql.Data.MySqlClient;

namespace DBConnectivity
{
    class MyDbClass
    {
        MySqlConnection mySqlConnection;

        public MyDbClass()
        {
            try
            {

                string connectionDetails = "server=127.0.0.1;database=library;uid=root;pwd=VueData@2023";

                mySqlConnection = new MySqlConnection();

                mySqlConnection.ConnectionString = connectionDetails;


            }
            catch (Exception a)
            {
                Console.WriteLine("ghjhytre", a.StackTrace);
            }

        }


        public void getData()
        {

            //string connectionDetails = "server=127.0.0.1;database=library1;uid=root;pwd=VueData@2023";

            //MySqlConnection mySqlConnection = new MySqlConnection();

            //mySqlConnection.ConnectionString = connectionDetails;        

            mySqlConnection.Open();   

            MySqlCommand mySqlCommand = new MySqlCommand("select * from library_books", mySqlConnection);

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            Console.WriteLine("Book Id\t Genre Id\t Published Date\t\t Book Name\t\t\t");

            while (mySqlDataReader.Read())
            {

                Console.Write($"{mySqlDataReader["book_id"]}\t");
                Console.Write($"{mySqlDataReader["genre_id"]}\t\t");
                Console.Write($"{mySqlDataReader["published_date"]}\t");
                Console.Write($"{mySqlDataReader["book_name"]}\t\t");
                Console.WriteLine();

            }
        
            mySqlConnection.Close();
        }
    
            

        public List<LedgerModel> getLedgerData()
        {
            List<LedgerModel> ledgerData = new List<LedgerModel>();

            try
            {

              mySqlConnection.Open();

                Console.Write("Enter Start Date (YYYY-MM-DD) : ");
                string? startDate = Console.ReadLine();
                Console.Write("Enter End Date (YYYY-MM-DD) : ");
                string? endDate = Console.ReadLine();

                MySqlCommand mySqlCommand = new MySqlCommand("select lbl.ledger_id, lc.customer_name, " +
                    "lc.customer_phone, lb.book_name, bg.genre_name, lbl.book_out_date from library_book_ledger lbl " +
                    "inner join library_customer lc on lbl.customer_id = lc.customer_id inner join library_books lb " +
                    "on lb.book_id=lbl.book_id inner join book_genre bg on bg.genre_id = lb.genre_id where " +
                    $"lbl.book_out_date between '{startDate}' and '{endDate}' " +
                    "order by lc.customer_name asc, lbl.book_out_date asc", mySqlConnection);



                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    ledgerData.Add(new LedgerModel(
                        Convert.ToInt32(mySqlDataReader["ledger_id"]),
                        Convert.ToString(mySqlDataReader["customer_name"]),
                        Convert.ToString(mySqlDataReader["customer_phone"]),
                        Convert.ToString(mySqlDataReader["book_name"]),
                        Convert.ToString(mySqlDataReader["genre_name"]),
                        Convert.ToDateTime(mySqlDataReader["book_out_date"])
                        ));
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                mySqlConnection.Close();
            }

            return ledgerData;
        }

    }

    class Main1
    {
        public static void Main(string[] args)
        {

            MyDbClass dbClass = new MyDbClass();

            dbClass.getData();

            List<LedgerModel> data = dbClass.getLedgerData();

            Console.WriteLine("Ledger Id       Customer Name\tCustomer Phone\tBook Name\t\t Book Out Date\t");

            foreach (var item in data)
            {
                Console.WriteLine($"{item.LedgerId}\t\t{item.CustomerName}\t\t{item.CustomerPhone}\t{item.BookName}\t{item.BookOutDate}");
            }

            Console.ReadLine();

        }

    }
}
