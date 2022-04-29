using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MPGuiVersion
{
    class BookkeepingModule
    {
        public float totalCredit = 0;
        public float totalDebit = 0;
        public void addTransaction(Transaction T)
        {
            SqlConnection conn;
            string message;
            bool state;
            DatabaseConnection.connectToSQL(out conn, out state, out message);
            DatabaseConnection.addTransaction(conn, T);
            DatabaseConnection.disconnectSQL(conn, out state);
        }

        public void deleteTransaction(int target_id)
        {
            SqlConnection conn;
            bool status;
            string output;

            DatabaseConnection.connectToSQL(out conn, out status, out output);
            DatabaseConnection.deleteTransaction(conn, target_id);
            DatabaseConnection.disconnectSQL(conn, out status);
        }

        public void modifyTransaction()
        {

        }

        public void calculateTotal()
        {

        }

        public void TotalValues(out float TC, out float TD)
        {
            TC = this.totalCredit;
            TD = this.totalDebit;
        }
    }
}