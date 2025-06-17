using System;
using System.Data.SqlClient;
using System.IO;

namespace QualcoLab2025.Task5
{

    //Model class
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductsInterfaceOld
    {
        public Product GetProductById(int id)
        {
            using (var conn = new SqlConnection("connection_string"))
            {
                var cmd = new SqlCommand("SELECT Id, Name FROM Products WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && int.TryParse(reader["Id"].ToString(), out int number))
                    {
                        return new Product
                        {
                            Id = number,
                            Name = reader["Name"].ToString()
                        };
                    }
                }
            }

            return null; // Not found
        }
    }

    /////////////////////////////////////////////////
    ///


    // Clean Architecture Version

}

