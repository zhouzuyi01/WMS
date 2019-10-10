using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;

namespace WmsDemo
{
    public class MaterielManage
    {
        public static void AddMateriel(Materiel materiel)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"insert into tb_materiel values ('{materiel.materielcode}','{materiel.materielname}')";
                conn.Execute(sql);
                conn.Close();
            }
        }

        public static void AddProperty(Materiel_Property property)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"insert into tb_materiel_property values ('{property.materielcode}','{property.propertyname}','{property.propertyvalue}')";
                conn.Execute(sql);
                conn.Close();
            }
        }

        public static void RemoveProperty(string materielcode, string propertyname)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"delete from tb_materiel_property where MaterielCode='{materielcode}' and PropertyName='{propertyname}'";
                conn.Execute(sql);
                conn.Close();
            }
        }

        public static List<Materiel_Property> SelectProperty(string materielcode)
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"select * from tb_materiel_property where MaterielCode='{materielcode}'";
                var list = conn.Query<Materiel_Property>(sql);
                conn.Close();
                return list?.ToList();
            }
        }

        public static List<Materiel> SelectMateriel()
        {
            using (var conn = SqlBase.Create())
            {
                var sql = $"select * from tb_materiel";
                var list = conn.Query<Materiel>(sql);
                conn.Close();
                return list?.ToList();
            }
        }


    }

    public class Materiel
    {
        public string materielcode { get; set; }

        public string materielname { get; set; }
    }

    public class Materiel_Property
    {
        public string materielcode { get; set; }

        public string propertyname { get; set; }

        public string propertyvalue { get; set; }
    }
}
