using AvaSpace.Domain.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AvaSpace.Infrastructure.Repositories
{
    public class UserRepository
    {
        public int Create(User user)
        {
            string sql = "INSERT INTO Users (Name, Email, BirthDate, Gender, ProfilePicturePath, CoverPhotoPath, Password, Active, CreateDate) " +
                        "values (@Name, @Email, @BirthDate, @Gender, @ProfilePicturePath, @CoverPhotoPath, @Password, @Active, @CreateDate)";
            using (var connection = new SqlConnection(""))
            {
                return connection.Execute(sql,
                    new
                    {
                        user.Name,
                        user.Email,
                        user.BirthDate,
                        user.Gender,
                    });
            }
        }

        public async Task<int> DeactivateAsync(int idUser)
        {
            string sql = "UPDATE Users SET  Active = @Active where Id = @Id";
            using (var connection = new SqlConnection(""))
            {
                return await connection.ExecuteAsync(sql,
                    new
                    {
                        Id = idUser,
                        Active = '0'
                    });
            }
        }

        public async Task<IEnumerable<User>> ReadAsync()
        {
            string sql = "SELECT * FROM Users";
            using (var connection = new SqlConnection(""))
            {
                return await connection.QueryAsync<User>(sql);
            }
        }

        public async Task<IEnumerable<User>> ReadAsync(int idUser)
        {
            string sql = "SELECT * FROM Users WHERE Id = @Id;";
            using (var connection = new SqlConnection(""))
            {
                return await connection.QueryAsync<User>(sql, new { Id = idUser });
            }
        }

        public async Task<int> UpdateAsync(User user)
        {
            string sql = "UPDATE Users SET " +
                         "Name = @Name, " +
                         "Email = @Email, " +
                         "BirthDate = @BirthDate, " +
                         "Gender = @Gender, " +
                         "ProfilePicturePath = @ProfilePicturePath, " +
                         "CoverPhotoPath = @CoverPhotoPath, " +
                         "Password = @Password, " +
                         "Active = @Active " +
                         "WHERE Id = @Id ";

            using (var connection = new SqlConnection(""))
            {
                return await connection.ExecuteAsync(sql,
                    new
                    {
                        user.Name,
                        user.Email,
                        user.BirthDate,
                        user.Gender
                    });
            }
        }
    }
}
