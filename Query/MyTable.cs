using System.Collections.Generic;

namespace Query
{
    public static class MyTable
    {

        public static List<Models.MyTable> GetList(int userId)
        {
            return Sql.Populate<Models.MyTable>("MyTable_GetList", new { userId });
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
