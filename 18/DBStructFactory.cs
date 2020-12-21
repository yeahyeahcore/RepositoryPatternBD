using System;
using System.Collections.Generic;
using Npgsql;
using System.Data.Common;
using System.Text.RegularExpressions;

namespace _18
{
    class DBStructFactory
    {
        private string connectionString = "Host=25.40.105.149;Username=admin;Password=admin;Database=dblesson";
        private string workerCmd, fucktoryCmd, categoryCmd;
        private string workerPattern = @"\w* Worker\w*";
        private string fucktoryPattern = @"\w* Fucktory\w*";
        private string categoryPattern = @"\w* Category\w*";

        Worker wk;
        Fucktory fk;
        Category ct;



        public DBStructFactory() { }
        public DBStructFactory(params string[] args)
        {
            wk = new Worker();
            fk = new Fucktory();
            ct = new Category();

            for(int i = 0; i < args.Length; i++)
            {
                if (Regex.IsMatch(args[i], workerPattern, RegexOptions.IgnoreCase))
                {
                    this.workerCmd = args[i];
                }

                if (Regex.IsMatch(args[i], fucktoryPattern, RegexOptions.IgnoreCase))
                {
                    this.fucktoryCmd = args[i];
                }

                if (Regex.IsMatch(args[i], categoryPattern, RegexOptions.IgnoreCase))
                {
                    this.categoryCmd = args[i];
                }
            }
        }
        
        public void ExecuteWorker(string typeEx, string cmd, Worker obj)
        {
            wk = new Worker();
            switch(typeEx)
            {
                case "Insert":
                    wk.Insert(connectionString, cmd, obj);
                    break;
                case "Update":
                    wk.Update(connectionString, cmd, obj);
                    break;
                case "Delete":
                    wk.Delete(connectionString, cmd);
                    break;
            }
        }

        public void ExecuteFucktory(string typeEx, string cmd, Fucktory obj)
        {
            fk = new Fucktory();
            switch (typeEx)
            {
                case "Insert":
                    fk.Insert(connectionString, cmd, obj);
                    break;
                case "Update":
                    fk.Update(connectionString, cmd, obj);
                    break;
                case "Delete":
                    fk.Delete(connectionString, cmd);
                    break;
            }
        }

        public void ExecuteCategory(string typeEx, string cmd, Category obj)
        {
            ct = new Category();
            switch (typeEx)
            {
                case "Insert":
                    ct.Insert(connectionString, cmd, obj);
                    break;
                case "Update":
                    ct.Update(connectionString, cmd, obj);
                    break;
                case "Delete":
                    ct.Delete(connectionString, cmd);
                    break;
            }
        }

        public List<Worker> Workers
        {
            get { return wk.Select(connectionString, workerCmd); }
        }

        public List<Fucktory> Fucktories
        {
            get { return fk.Select(connectionString, fucktoryCmd); }
        }

        public List<Category> Categories
        {
            get { return ct.Select(connectionString, categoryCmd); }
        }
    }

    class Category
    {
        public int Id { get; set; }
        public string Category_name { get; set; }

        public void Insert(string connString, string commandString, Category category)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("name", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters[0].Value = category.Category_name;
                    cmd.ExecuteNonQuery();
                }
                npgSqlConnection.Close();
            }
        }

        public void Update(string connString, string commandString, Category category)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("name", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters[0].Value = category.Category_name;

                    cmd.ExecuteNonQuery();
                }
                npgSqlConnection.Close();
            }
        }

        public void Delete(string connString, string commandString)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection))
                {
                    cmd.ExecuteNonQuery();
                }
                npgSqlConnection.Close();
            }
        }

        public List<Category> Select(string connString, string commandString)
        {
            List<Category> _category_list = new List<Category>();
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection);

                using (NpgsqlDataReader npgSqlDataReader = cmd.ExecuteReader())
                {
                    if (npgSqlDataReader.HasRows)
                    {

                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                        {
                            _category_list.Add(new Category
                            {
                                Id = Convert.ToInt16(dbDataRecord["id"]),
                                Category_name = Convert.ToString(dbDataRecord["Category_name"]),
                            });
                        }
                        npgSqlConnection.Close();
                        return _category_list;
                    }
                    else { npgSqlConnection.Close(); return null; }
                }
            }
        }
    }

    class Fucktory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Products_value { get; set; }
        public int Worker_value { get; set; }
        public string Diector_fname { get; set; }
        public int Category_id { get; set; }

        public void Insert(string connString, string commandString, Fucktory fucktory)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("name", NpgsqlTypes.NpgsqlDbType.Smallint));
                    cmd.Parameters.Add(new NpgsqlParameter("pv", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters.Add(new NpgsqlParameter("wv", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters.Add(new NpgsqlParameter("dfname", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters.Add(new NpgsqlParameter("c_id", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters[0].Value = fucktory.Name;
                    cmd.Parameters[1].Value = fucktory.Products_value;
                    cmd.Parameters[2].Value = fucktory.Worker_value;
                    cmd.Parameters[3].Value = fucktory.Diector_fname;
                    cmd.Parameters[3].Value = fucktory.Category_id;

                    cmd.ExecuteNonQuery();
                }
                npgSqlConnection.Close();
            }
        }

        public void Update(string connString, string commandString, Fucktory fucktory)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("name", NpgsqlTypes.NpgsqlDbType.Smallint));
                    cmd.Parameters.Add(new NpgsqlParameter("pv", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters.Add(new NpgsqlParameter("wv", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters.Add(new NpgsqlParameter("dfname", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters.Add(new NpgsqlParameter("c_id", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters[0].Value = fucktory.Name;
                    cmd.Parameters[1].Value = fucktory.Products_value;
                    cmd.Parameters[2].Value = fucktory.Worker_value;
                    cmd.Parameters[3].Value = fucktory.Diector_fname;
                    cmd.Parameters[3].Value = fucktory.Category_id;

                    cmd.ExecuteNonQuery();
                }
                npgSqlConnection.Close();
            }
        }

        public void Delete(string connString, string commandString)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection))
                {
                    cmd.ExecuteNonQuery();
                }
                npgSqlConnection.Close();
            }
        }

        public List<Fucktory> Select(string connString, string commandString)
        {
            List<Fucktory> _fucktories = new List<Fucktory>();
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection);

                using (NpgsqlDataReader npgSqlDataReader = cmd.ExecuteReader())
                {
                    if (npgSqlDataReader.HasRows)
                    {

                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                        {
                            _fucktories.Add(new Fucktory
                            {
                                Id = Convert.ToInt16(dbDataRecord["Id"]),
                                Name = Convert.ToString(dbDataRecord["Name"]),
                                Products_value = Convert.ToInt16(dbDataRecord["Products_value"]),
                                Worker_value = Convert.ToInt16(dbDataRecord["Worker_value"]),
                                Diector_fname = Convert.ToString(dbDataRecord["Diector_fname"]),
                                Category_id = Convert.ToInt16(dbDataRecord["Category_id"]),
                            });
                        }
                        npgSqlConnection.Close();
                        return _fucktories;
                    }
                    else { npgSqlConnection.Close(); return _fucktories; }
                }
            }
        }
    }

    class Worker
    {
        public int Id { get; set; }
        public int FucktoryId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Pname { get; set; }

        public void Insert(string connString, string commandString, Worker worker)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection))
                {
                    cmd.Parameters.AddWithValue("id", worker.FucktoryId);
                    cmd.Parameters.AddWithValue("f", worker.Fname);
                    cmd.Parameters.AddWithValue("l", worker.Lname);
                    cmd.Parameters.AddWithValue("p", worker.Pname);
                    cmd.ExecuteNonQuery();
                }
                npgSqlConnection.Close();
            }
        }

        public void Update(string connString, string commandString, Worker worker)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Smallint));
                    cmd.Parameters.Add(new NpgsqlParameter("f", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters.Add(new NpgsqlParameter("l", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters.Add(new NpgsqlParameter("p", NpgsqlTypes.NpgsqlDbType.Char));
                    cmd.Parameters[0].Value = worker.FucktoryId;
                    cmd.Parameters[1].Value = worker.Fname;
                    cmd.Parameters[2].Value = worker.Lname;
                    cmd.Parameters[3].Value = worker.Pname;

                    cmd.ExecuteNonQuery();
                }
                npgSqlConnection.Close();
            }
        }

        public void Delete(string connString, string commandString)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(commandString, npgSqlConnection);
                cmd.ExecuteNonQuery();
                npgSqlConnection.Close();
            }
        }

        public List<Worker> Select(string connString, string commandString)
        {
            List<Worker> _workers = new List<Worker>();
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand worker_command = new NpgsqlCommand(commandString, npgSqlConnection);

                using (NpgsqlDataReader npgSqlDataReader = worker_command.ExecuteReader())
                {
                    if (npgSqlDataReader.HasRows)
                    {

                        foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                        {
                            _workers.Add(new Worker
                            {
                                Id = Convert.ToInt16(dbDataRecord["id"]),
                                FucktoryId = Convert.ToInt16(dbDataRecord["FucktoryId"]),
                                Fname = Convert.ToString(dbDataRecord["Fname"]),
                                Lname = Convert.ToString(dbDataRecord["Lname"]),
                                Pname = Convert.ToString(dbDataRecord["Pname"]),
                            });
                        }
                        npgSqlConnection.Close();
                        return _workers;
                    }
                    else { npgSqlConnection.Close(); return null; }
                }
            }
        }
    }
}
