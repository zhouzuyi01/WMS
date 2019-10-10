using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace WmsDemo
{
    public class AreaManage
    {
        public static void AddArea(Area area)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"insert into tb_area values ('{area.areacode}','{area.areaname}','{area.warecode}')";
                conn.Execute(sql);
                conn.Close();
            }
        }

        public static List<Area> SelectArea(string warecode)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = "select * from tb_area";
                var list = conn.Query<Area>(sql);
                conn.Close();
                return list?.ToList();
            }
        }

        public static void SetMateriel(string areacode, string materielcode)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"insert into tb_area_materiel values ('{areacode}','{materielcode}')";
                conn.Execute(sql);
                conn.Close();
            }
        }

        public static List<AreaMateriel> SelectMaterielByArea(string areacode)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"select * from tb_area_materiel where AreaCode='{areacode}'";
                var list = conn.Query<AreaMateriel>(sql);
                conn.Close();
                return list?.ToList();
            }
        }

        public static void RemoveMateriel(string areacode, string materielcode)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"delete from tb_area_materiel where AreaCode='{areacode}' and MaterielCode='{materielcode}'";
                conn.Execute(sql);
                conn.Close();
            }
        }

        public static void SetPoint(string areacode, string pointcode)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"insert into tb_area_point values ('{areacode}','{pointcode}')";
                conn.Execute(sql);
                conn.Close();
            }
        }

        public static void RemovePoint(string areacode, string pointcode)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"delete from tb_area_point where AreaCode='{areacode}' and PointCode='{pointcode}'";
                conn.Execute(sql);
                conn.Close();
            }
        }
    }

    public class Area
    {
        public string areacode { get; set; }

        public string areaname { get; set; }

        public string warecode { get; set; }
    }

    public class AreaMateriel
    {
        public string AreaCode { get; set; }

        public string MaterielCode { get; set; }
    }
}
