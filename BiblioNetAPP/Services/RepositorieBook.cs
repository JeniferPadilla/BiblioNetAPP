using BiblioNetAPP.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BiblioNetAPP.Services
{
    public interface IRepositorieBook
    {
        void Create(Book book);
    }
    public class RepositorieBook : IRepositorieBook
    {
        private readonly string connectionString;

        public RepositorieBook(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public void Create(Book book)
        {
            using var connection = new SqlConnection(connectionString);

            var id = connection.QuerySingle<int>($@"INSERT INTO Books
                                             (Title,Description,AuthorId,Pages,
                                              PublicationDate,RegisterDate,CategoryId)
                                              VALUES (@Title, @Description, @AuthorId,@Pages,
                                              @PublicationDate, @RegisterDate,@CategoryId ) ;
                                              select SCOPE_IDENTITY();",book);
            book.Id = id;
        }
    }
}
