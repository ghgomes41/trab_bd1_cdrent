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
        }

        public String testeInsert(String SelectQuery)
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

        public DataTable carregaCB(String QueryCarrega)
        //Dictionary<int,string>
        {
            //Dictionary<int, string> Combo = new Dictionary<int, string>();
            //String Result = "";
            
            
                DataTable dt = new DataTable();
                try
                {
                    using (OleDbConnection csconexao = new OleDbConnection(conecta))
                    {
                        csconexao.Open();
                        using (OleDbDataAdapter da = new OleDbDataAdapter(QueryCarrega, csconexao))
                        {
                            da.Fill(dt);
                        }
                        csconexao.Close();
                        return dt;
                    }

                }
                catch
                {
                    return null;
                }
                /*try {
                 * using (OleDbConnection csconexao = new OleDbConnection(conecta))
                    {
                    csconexao.Open();
                    using (OleDbCommand cscomando = new OleDbCommand(QueryCarrega, csconexao))
                    {
                        var DataReader = cscomando.ExecuteReader();
                        while (DataReader.Read())
                        {
                            int id = Convert.ToInt32(DataReader["id"]);
                            Combo.Add(id, DataReader["nome"].ToString());
                        }
                    }
                    csconexao.Close();
                    return Combo;
                }
            }
            catch (OleDbException Ex) {
                return null;
            }*/
            }

        public DataTable mostraTabela(String QueryTabela)
        {
            DataTable dt = new DataTable();
            try
            {
                using (OleDbConnection csconexao = new OleDbConnection(conecta)) {
                    csconexao.Open();
                    using (OleDbDataAdapter da = new OleDbDataAdapter(QueryTabela, csconexao))
                    {
                        da.Fill(dt);
                    }
                    csconexao.Close();
                    return dt;
                }
                
            }
            catch
            {
                return null;
            }
        }

        public String consultaClienteFuncionario(String SelectQuery)
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
                            Result = DataReader["ctps"].ToString();
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
        }

        public String ConsultaIdCD(String SelectQuery)
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
                            Result = DataReader["id_cd"].ToString();
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
        }
    }
}
