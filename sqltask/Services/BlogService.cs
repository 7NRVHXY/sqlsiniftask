using ADO.NET.Helpers;
using sqltask.Models;
using sqltask.Services;
using System.Data;

namespace ADO.NET.Services;

public class ArtistService : IBaseService<Blog>
{
    public int Create(Blog data)
    {
        string query = $"INSERT INTO Artists VALUES (N'{data.Title}', N'{data.Description}', )";
        return SqlHelper.Exec(query);
    }

    public int Delete(int id)
    {
        string query = $"DELETE Artists WHERE Id = {id}";
        return SqlHelper.Exec(query);
    }

    public List<Blog> GetAll()
    {
        DataTable dt = SqlHelper.GetDatas("SELECT * FROM Artists");
        List<Blog> list = new List<Blog>();
        foreach (DataRow row in dt.Rows)
        {
            list.Add(new Blog
            {
                Id = (int)row["Id"],
                Title = (string)row["Title"],
                Description = (string)row["Description"],
               UserId = (int)row["UserId"]  
            });
        }
        return list;
    }

    public Blog GetById(int id)
    {
        DataTable dt = SqlHelper.GetDatas($"SELECT *FROM Blogs where Id={id}");
        foreach (DataRow row in dt.Rows)
        {
            Blog blog = new Blog
            {
                Id = (int)row["Id"],
                Title = (string)row["Title"],
                Description = (string)row["Description"],
                UserId = (int)row["UserId"]
            };
        return blog;
        }
        return null;

    }

    public List<Blog> GetWhere(string query)
    {
        throw new NotImplementedException();
    }

    public int Update(int id, Blog data)
    {
        throw new NotImplementedException();
    }
}
