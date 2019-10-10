using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace WmsDemo
{
    public class WareManage
    {
        public static void AddWare(Ware ware)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"insert into tb_ware values ('{ware.warecode}','{ware.warename}', '{ware.enable}', {ware.rowcount}, {ware.columncount},{ware.layercount})";
                conn.Execute(sql);
                conn.Close();
            }
        }

        public static List<Ware> SelectWare()
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"select * from tb_ware";
                var list = conn.Query<Ware>(sql);
                conn.Close();
                return list?.ToList();
            }
        }
    }

    public class Ware
    {
        public string warecode { get; set; }

        public string warename { get; set; }

        public bool enable { get; set; }

        public int rowcount { get; set; }

        public int columncount { get; set; }

        public int layercount { get; set; }
    }
}
