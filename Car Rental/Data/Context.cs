using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Car_Rental.Data;

namespace Car_Rental
{
    public class Context
    {
        private SqlConnection connection;

        private DataSet set;

        private Dictionary<TableName, DataTable> tables;
        private Dictionary<TableName, SqlDataAdapter> adapters;
        private Dictionary<TableRelation, DataRelation> relations;

        public Context(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);

            set = new DataSet();

            tables = new Dictionary<TableName, DataTable>();
            adapters = new Dictionary<TableName, SqlDataAdapter>();
            relations = new Dictionary<TableRelation, DataRelation>();

            initializeTables();
        }

        #region GETTERS

        public int tableCount()
        {
            return tables.Count;
        }

        public DataTable getTable(TableName name)
        {
            return tables[name];
        }

        public SqlDataAdapter getAdapter(TableName name)
        {
            return adapters[name];
        }

        public DataRelation getRelation(TableRelation name)
        { 
            return relations[name];
        }

        #endregion

        #region CONFIGURATION

        public DataTable initializeTable(TableName name)
        {
            DataTable table = new DataTable(name.ToString());

            string query = "SELECT * FROM " + name.ToString();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            new SqlCommandBuilder(adapter);

            adapter.Fill(table);

            set.Tables.Add(table);
            tables.Add(name, table);
            adapters.Add(name, adapter);

            return table;
        }

        public void initializeTables()
        {
            foreach (TableName name in Enum.GetValues(typeof(TableName)))
                initializeTable(name);
        }

        #endregion

        #region MANIPULATION

        public void insert(TableName name, params object[] values)
        {
            getTable(name).Rows.Add(values);

            save();
        }

        public void update(TableName name, object key, params object[] values)
        {
            DataRow r = find(name, key);

            for (int i = 0; i < values.Length; i++)
                r[i + 1] = values[i];

            save();
        }

        public void save()
        {
            foreach (TableName name in adapters.Keys)
                adapters[name].Update(tables[name]);
        }

        #endregion

        #region SELECTION

        public DataRow find(TableName name, object key)
        {
            return getTable(name).Rows.Find(key);
        }

        #endregion

        #region RELATIONS

        public DataRelation initializeRelation(TableRelation name, DataColumn parent, DataColumn child)
        {
            DataRelation r = new DataRelation(name.ToString(), parent, child);

            relations.Add(name, r);
            set.Relations.Add(r);

            return r;
        }

        public DataRow[] findChildren(DataRow row, TableRelation relationName)
        {
            return row.GetChildRows(getRelation(relationName));
        }

        public DataRow[] findChildren(TableName tableName, object key, TableRelation relationName)
        {
            return findChildren(find(tableName, key), relationName);
        }

        #endregion
    }
}
