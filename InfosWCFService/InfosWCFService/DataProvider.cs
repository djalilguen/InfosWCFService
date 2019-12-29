using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InfosWCFService
{
    public class DataProvider
    {
        public static List<Article> GetArticles()
        {
            List<Article> resultats = new List<Article>();
            Article article;

            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = "Server=127.0.0.1;Uid=root;Pwd=root;Database=infos;";

            cnx.Open();


            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "articles";
            cmd.CommandType = CommandType.TableDirect;
            cmd.Connection = cnx;

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                article = new Article();
                article.num = (int)dr["num"];
                article.title = (String)dr["title"];
                article.text = (String)dr["text"];
                article.likes = (int)dr["likes"];
                article.dislikes = (int)dr["dislikes"];
                resultats.Add(article);
            }
            cnx.Close();
            return resultats;
        }


        public static bool addArticle(Article art)
        {
            MySqlConnection cnx = null ;
            try
            {
                bool resultat = false;
                cnx = new MySqlConnection();
                cnx.ConnectionString = "Server=127.0.0.1;Uid=root;Pwd=root;Database=infos;";

                cnx.Open();

                MySqlCommand cmd = new MySqlCommand(); //Ou : MySqlCommand cmd = cnx.CreateCommand();

                cmd.CommandText = "insert into articles values (@num,@title,@text,@likes,@dislikes) ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("num", art.num);
                cmd.Parameters.AddWithValue("title", art.title);
                cmd.Parameters.AddWithValue("text", art.text);
                cmd.Parameters.AddWithValue("likes", art.likes);
                cmd.Parameters.AddWithValue("dislikes", art.dislikes);
                cmd.Connection = cnx;

                int n = cmd.ExecuteNonQuery();
                if (n > 0) resultat = true;
                cnx.Close();
                return resultat;
            }
            catch (Exception ex) {
                cnx.Close();
                return false;
            }
            
        }

    }
}