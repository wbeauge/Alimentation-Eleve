   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Alimentation_Eleve
{
    class TableEleve
    {
         private MySqlConnection cnx;

         public TableEleve()
        {
            cnx = ConnectionMySql.GetConnection();
        }

        public void Insert(Eleve unEleve, int idClasse)
        {

            cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand();

            cmdSql.Connection = cnx;
            cmdSql.CommandText = "insert into aauth_users (email,pass,username) values (@email,@pass,@username);";
            cmdSql.CommandType = CommandType.Text;

            cmdSql.Parameters.Add("@email", MySqlDbType.String);
            cmdSql.Parameters["@email"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@email"].Value = unEleve.Prenom;

            cmdSql.Parameters.Add("@pass", MySqlDbType.String);
            cmdSql.Parameters["@pass"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@pass"].Value = unEleve.PassWord;

            cmdSql.Parameters.Add("@username", MySqlDbType.Int32);
            cmdSql.Parameters["@username"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@username"].Value = unEleve.Login;

            cmdSql.ExecuteNonQuery();

            cmdSql.Connection = cnx;
            cmdSql.CommandText = "select id from aauth_users where email = @email and pass = @pass;";
            cmdSql.CommandType = CommandType.Text;

            cmdSql.Parameters.Add("@email", MySqlDbType.String);
            cmdSql.Parameters["@email"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@email"].Value = unEleve.Prenom;

            cmdSql.Parameters.Add("@pass", MySqlDbType.String);
            cmdSql.Parameters["@pass"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@pass"].Value = unEleve.PassWord;

            int idauth;
            idauth = (int)cmdSql.ExecuteScalar();

            cmdSql.Connection = cnx;
            cmdSql.CommandText = "insert into eleve (nom,prenom,login,idAuth,idClasse) values (@nom,@prenom,@login,@password,@idAuth,@idClasse);";
            cmdSql.CommandType = CommandType.Text;

            cmdSql.Parameters.Add("@nom", MySqlDbType.String);
            cmdSql.Parameters["@nom"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@nom"].Value = unEleve.Nom;

            cmdSql.Parameters.Add("@prenom", MySqlDbType.String);
            cmdSql.Parameters["@prenom"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@prenom"].Value = unEleve.Prenom;

            cmdSql.Parameters.Add("@login", MySqlDbType.String);
            cmdSql.Parameters["@login"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@login"].Value = unEleve.Login;

            cmdSql.Parameters.Add("@idAuth", MySqlDbType.Int32);
            cmdSql.Parameters["@idAuth"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@idAuth"].Value = idauth;

            cmdSql.Parameters.Add("@idClasse", MySqlDbType.Int32);
            cmdSql.Parameters["@idClasse"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@idClasse"].Value = idClasse;


            cmdSql.ExecuteNonQuery();

            cnx.Close();

            
        }
    }
}
