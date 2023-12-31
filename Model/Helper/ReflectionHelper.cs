﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model.Helper
{
    public static class ReflectionHelper
    {
        public static T ToObject<T>(this DataRow dataRow)
     where T : new()
        {
            T item = new T();
            foreach (DataColumn column in dataRow.Table.Columns)
            {
                if (dataRow[column] != DBNull.Value)
                {
                    PropertyInfo prop = item.GetType().GetProperty(column.ColumnName);
                    if (prop != null)
                    {
                        object result = Convert.ChangeType(dataRow[column], prop.PropertyType);
                        prop.SetValue(item, result, null);
                        continue;
                    }
                    else
                    {
                        FieldInfo fld = item.GetType().GetField(column.ColumnName);
                        if (fld != null)
                        {
                            object result = Convert.ChangeType(dataRow[column], fld.FieldType);
                            fld.SetValue(item, result);
                        }
                    }
                }
            }
            return item;
        }
        public static List<T> ToList<T>(this DataTable dataTable) where T : new()
        {
            var list = new List<T>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                T item = new T();
                foreach (DataColumn column in dataRow.Table.Columns)
                {
                    if (dataRow[column] != DBNull.Value)
                    {
                        PropertyInfo prop = item.GetType().GetProperty(column.ColumnName);
                        if (prop != null)
                        {
                            object result = Convert.ChangeType(dataRow[column], prop.PropertyType);
                            prop.SetValue(item, result, null);
                            continue;
                        }
                        else
                        {
                            FieldInfo fld = item.GetType().GetField(column.ColumnName);
                            if (fld != null)
                            {
                                object result = Convert.ChangeType(dataRow[column], fld.FieldType);
                                fld.SetValue(item, result);
                            }
                        }
                    }
                }
                list.Add(item);
            }
            return list;
        }
    }
}
