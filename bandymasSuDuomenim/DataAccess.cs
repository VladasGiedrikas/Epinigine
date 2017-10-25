using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace bandymasSuDuomenim
{
    public class DataAccess
    {
        public List<Islaidos> GetIslaidos(string islaidosMaistui)
        {
            // prisijungimas prie duomenu bazes
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("IslaidosDB")))
            {
                return connection.Query<Islaidos>($"select * from VisosIslaidos where IslaidosMaistui = '{islaidosMaistui}'").ToList();
            }
        }
        public void InsertIslaidos(int islaidosMaistui, int islaidosTransportui, int islaidosKitos )
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("IslaidosDB")))
            {
                // Person newPerson = new Person { FirstName = firstName, LastName = lastName, Age = age };
                List<Islaidos> irasai = new List<Islaidos>();
                irasai.Add(new Islaidos { IslaidosMaistui = islaidosMaistui, IslaidosTransportui = islaidosTransportui, IslaidosKitos = islaidosKitos });
                //connection.Execute("dbo.People_Insert @FirstName @LastName @Age", people);
                connection.Execute($"INSERT INTO VisosIslaidos (IslaidosMaistui, IslaidosTransportui, IslaidosKitos) VALUES('{islaidosMaistui}', '{islaidosTransportui}', '{islaidosKitos}' )");
            }
        }
        public int PridetiLabelMaistui()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("IslaidosDB")))
            {
                return connection.ExecuteScalar<int>($"SELECT SUM(IslaidosMaistui)FROM VisosIslaidos");                    
            }
        }
        public int PridetiLabelTransportui()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("IslaidosDB")))
            {
                return connection.ExecuteScalar<int>($"SELECT SUM(IslaidosTransportui)FROM VisosIslaidos");            
            }
        }
        public int PridetiLabelKitos()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("IslaidosDB")))
            {
                return connection.ExecuteScalar<int>($"SELECT SUM(IslaidosKitos)FROM VisosIslaidos");            
            }
        }
        public int LabelBendrasBiudzetas()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("IslaidosDB")))
            {
                return connection.ExecuteScalar<int>($"SELECT SUM(BendrasBiudzetas)FROM VisosIslaidos");
            }
        }
        public List<Islaidos> GetALLData()
        {           
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("IslaidosDB")))
            {
                return connection.Query<Islaidos>($"select * from VisosIslaidos ").ToList();
            }
        }

    }
}