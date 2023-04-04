using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data
{
    public class DataTableDBhelper
    {
        public List<T> ConvertDataTableToList<T>(DataTable dt)
        {
            List<T> data = new List<T>();  // 创建一个空的泛型List

            // 循环遍历DataTable中的每一行数据
            foreach (DataRow row in dt.Rows)
            {
                // 使用GetItem方法将DataRow转换为指定类型的对象
                T item = GetItem<T>(row);
                data.Add(item);  // 将对象添加到泛型List中
            }

            return data;  // 返回泛型List
        }

        // 该方法将一个DataRow转换为指定类型的对象
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);  // 获取指定类型的Type对象
            T obj = Activator.CreateInstance<T>();  // 创建该类型的新对象

            // 遍历DataRow中的每一列数据
            foreach (DataColumn column in dr.Table.Columns)
            {
                // 使用反射获取指定类型的公共属性
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    // 如果属性名称与列名匹配，将该列的值分配给该属性
                    if (pro.Name == column.ColumnName)
                    {
                        // 检查该值是否可以转换为指定类型
                        object value = dr[column.ColumnName];
                        if (value != DBNull.Value)
                        {
                            if (pro.PropertyType == typeof(int))
                            {
                                int intValue;
                                if (int.TryParse(value.ToString(), out intValue))
                                {
                                    pro.SetValue(obj, intValue, null);
                                }
                                else
                                {
                                    // 无法转换为int类型，可以抛出异常或设置默认值
                                    // pro.SetValue(obj, 0, null);
                                    // throw new ArgumentException("无法将值转换为int类型");
                                }
                            }
                            else
                            {
                                pro.SetValue(obj, value, null);
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return obj;  // 返回新对象
        }


    }
}
