using GasStationAutomation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationAutomation.DataAccess
{
    public class DbContext:IDisposable
    {
        string _conString;
        public OleDbConnection _connection { get; }
        public DbContext()
        {
            _conString= String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""");
            _connection= new OleDbConnection(_conString);
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            var type = typeof(T);
            var props = type.GetProperties();
            OleDbCommand cmd = new OleDbCommand($"Select * From [{type.Name}s$]", _connection);
            _connection.Open();
            var reader = cmd.ExecuteReader();
            List<T> list = new();
            while (reader.Read())
            {
                var t = Activator.CreateInstance<T>();
                foreach (var property in props)
                {
                    property.SetValue(t, Convert.ChangeType(reader.GetValue(property.Name), property.PropertyType));
                }
                list.Add(t);
            }
            _connection.Close();
            return list;
        }

        public void Add<T>(T entity) where T : class
        {
            var type = typeof(T);
            var props = type.GetProperties();

            
            string command = $"Insert Into [{type.Name}s$] (";
            for(int i=0;i<props.Length;i++)
            {
                command += $"{props[i].Name}";
                if (i+1==props.Length)
                {
                    continue;
                }
                command += ",";
            }
            command += ") Values (";
            for (int i = 0; i < props.Length; i++)
            {
                command += $"\'{props[i].GetValue(entity)}\'";
                if (i + 1 == props.Length)
                {
                    continue;
                }
                command += ",";
            }
            command += ")";
            OleDbCommand cmd = new OleDbCommand(command, _connection);
            _connection.Open();
            var reader = cmd.ExecuteNonQuery();
            _connection.Close();
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}
