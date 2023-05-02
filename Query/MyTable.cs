using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using Saber.Core;

namespace Query
{
    public static class MyTable
    {

        public static List<Models.MyTable> GetList()
        {
            return Sql.Populate<Models.MyTable>("MyTable_GetList");
        }

        public static void Add(int userId, string text)
        {
            Sql.ExecuteNonQuery("MyTable_Add", new { userId, text });
        }

        public static void Update(int myId, string text)
        {
            Sql.ExecuteNonQuery("MyTable_Update", new { myId, text });
        }

        public static void Delete(int myId)
        {
            Sql.ExecuteNonQuery("MyTable_Delete", new { myId });
        }

    }
}
