using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabBD1cdloc
{
    class ConectaDB
    {
        static String conecta = @"Provider=SQLNCLI11;Server=localhost\SQLEXPRESS;Database=trabBD;Trusted_Connection=yes;";
        public ConectaDB()
        {
        }

        public String testeCon(String SelectQuery)
        {
            String Result = "";
            try
            {
                using (OleDbConnection csconexao = new OleDbConnection(conecta))
                {
                    csconexao.Open();
                    using (OleDbCommand cscomando = new OleDbCommand(SelectQuery, csconexao))
                    {
                        var DataReader = cscomando.ExecuteReader();
                        while (DataReader.Read())
                        {
                            Result = DataReader["nome"].ToString();
                        }
                    }
                    csconexao.Close();
                    return Result;
                }

            }
            catch (OleDbException Ex)
            {
                Result = Ex.Message;
                return Result;
            }
        }public String testeInsert(String SelectQuery)
        {
            String Result = "";
            try
            {
                using (OleDbConnection csconexao = new OleDbConnection(conecta))
                {
                    csconexao.Open();
                    //String SelectQuery = "";
                    using (OleDbCommand cscomando = new OleDbCommand(SelectQuery, csconexao))
                    {
                        cscomando.ExecuteNonQuery();
                        
                    }
                    csconexao.Close();
                    return Result;
                }

            }
            catch (OleDbException Ex)
            {
                Result = Ex.Message;
                return Result;
            }
        }
    }
}
