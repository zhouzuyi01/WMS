using System;
using System.Collections.Generic;
using Dapper;

namespace WmsDemo
{
    public class ContainerManage
    {
        public static void AddContainer(Container container)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"insert into tb_container values ('{container.containercode}','{container.materielcode}',{container.capacity})";
                conn.Execute(sql);
                conn.Close();
            }
        }

        public static List<Container> SelectContainer(string pointcode)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"select tb_container.ContainerCode,MaterielCode,Capacity from tb_container,tb_point_container where tb_container.ContainerCode=tb_point_container.ContainerCode and PointCode='{pointcode}'";
                var list = conn.Query<Container>(sql);
                conn.Close();
                return list?.AsList();
            }
        }

        public static List<Container> SelectContainerByWare(string wareCode)
        {
            using (var conn =SqlBase.Create())
            {
                var sql = $"select * from tb_container where substring(ContainerCode,1, 14)='{wareCode}'";
                var list = conn.Query<Container>(sql);
                conn.Close();
                return list?.AsList();
            }
        }
    }

    public class Container
    {
        public string containercode { get; set; }

        public string materielcode { get; set; }

        public double capacity { get; set; }
    }
}
