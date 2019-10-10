using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace WmsDemo
{
    public class PointManage
    {
        public static void AddPoint(Point point)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"insert into tb_point values ('{point.pointcode}','{point.warecode}','{point.pointstate}')";
                conn.Execute(sql);
                conn.Close();
            }
        }

        public static List<Point> SelectPointByWare(string warecode)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"select * from tb_point where WareCode='{warecode}'";
                var points = conn.Query<Point>(sql);
                conn.Close();
                return points?.ToList();
            }
        }

        public static List<Point> SelectPointByArea(string warecode, string areacode)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"select * from( select tb_point.PointCode,AreaCode,WareCode,PointState from tb_point left join tb_area_point on tb_point.PointCode=tb_area_point.PointCode )t where AreaCode='{areacode}' and WareCode='{warecode}'";
                if (string.IsNullOrEmpty(areacode))
                {
                    sql = $"select * from( select tb_point.PointCode,AreaCode,WareCode,PointState from tb_point left join tb_area_point on tb_point.PointCode=tb_area_point.PointCode )t where (AreaCode is null or AreaCode='') and WareCode='{warecode}'";
                }
                var points = conn.Query<Point>(sql);
                conn.Close();
                return points?.ToList();
            }
        }

        public static void SetContainer(string pointcode, string containercode)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"insert into tb_point_container values ('{pointcode}','{containercode}')";
                conn.Execute(sql);
                conn.Close();
            }
        }

        public static void RemoveContainer(string pointcode, string containercode)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"delete from tb_point_container where PointCode='{pointcode}' and ContainerCode='{containercode}'";
                conn.Execute(sql);
                conn.Close();
            }
        }
    }

    public class Point
    {
        public string pointcode { get; set; }

        public string areacode { get; set; }

        public string warecode { get; set; }

        public string pointstate { get; set; }
    }
}
