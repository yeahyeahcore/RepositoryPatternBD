using System;
using System.Collections.Generic;
using Npgsql;
using System.Data.Common;
using System.Text.RegularExpressions;
using System.Data;

namespace _18
{
    //Pattern Repository

    interface IRepositoryDB
    {
        void Select(string commandString);
        void GetQuery(string commandString);
        void Insert(string commandString);
        void Update(string commandString);
        void Remove(string commandString);
    }

    class DataBaseHandler : IRepositoryDB
    {
        public List<SportsMan> sportsMans { get; set; }
        public List<Trener> treners { get; set; }

        DataTable table;
        NpgsqlDataReader npgSqlDataReader;
        object singleRequest;

        string connString;
        public DataBaseHandler(string connString)
        { this.connString = connString; }

        public DataTable GetTable()
        { return table; }

        public NpgsqlDataReader GetReader()
        {
            return npgSqlDataReader;
        }

        public object GetQuery()
        {
            return singleRequest;
        }

        public void GetQuery(string commandString)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection);
                npgSqlDataReader = cmd.ExecuteReader();
                while (npgSqlDataReader.Read())
                {
                    singleRequest = npgSqlDataReader.GetValue(0);
                }
                npgSqlConnection.Close();
            }
        }

        public void Select(string commandString)
        {
            table = new DataTable();
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection);
                npgSqlDataReader = cmd.ExecuteReader();
                table.Load(npgSqlDataReader);
                npgSqlConnection.Close();
            }
        }

        public void Insert(string commandString)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection))
                { cmd.ExecuteNonQuery(); }
                npgSqlConnection.Close();
            }
        }

        public void Update(string commandString)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection))
                { cmd.ExecuteNonQuery(); }
                npgSqlConnection.Close();
            }
        }

        public void Remove(string commandString)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection);
                cmd.ExecuteNonQuery();
                npgSqlConnection.Close();
            }
        }
    }

    class SportsMan
    {
        public int Id { get; set; }
        public int Trener_Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string PName { get; set; }
        public string Sex { get; set; }
        public int BirthDay { get; set; }
        public string City { get; set; }
    }

    class Trener
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string PName { get; set; }
        public string Sex { get; set; }
        public int BirthDay { get; set; }
        public string City { get; set; }
        public int Rating { get; set; }
    }
}
