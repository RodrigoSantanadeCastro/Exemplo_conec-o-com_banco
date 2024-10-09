using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Aplicativo para treinar utilização e implementação com o mariaDB(via xampp)");
            Console.WriteLine("---------------------------------------------------------------------------");

            MySqlConnection conn;
            conn = new MySqlConnection("server=localhost;Database=ezystock;uid=root;pwd=''");
            MySqlCommand cmd;
            

            try
            {
                conn.Open();
                Console.WriteLine("connection success , wathing for a instruction");
               
            }
            catch (Exception ex)
            {

                Console.WriteLine("fail to connect , try again later");
            }

            string sql = "select * from fornecedores;";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("Id  "+ reader["id_fornecedores"]);
                Console.WriteLine("nome  " + reader["nome_fornecedor"]);
                Console.WriteLine("cnpj"+ reader["cnpj"]);
                Console.WriteLine("ramo  " + reader["ramo"]);
                Console.WriteLine("descrição  " + reader["descricao"]);

            }
            Console.ReadKey();



        }
    }
}
