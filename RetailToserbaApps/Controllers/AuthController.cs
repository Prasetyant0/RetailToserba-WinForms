using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailToserbaApps.Data;
using RetailToserbaApps.Models;

namespace RetailToserbaApps.Controllers
{
    public class AuthController
    {
        public User Login(string username, string password)
        {
            try
            {
                string sql = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password AND Status = 'Active'";
                var parameters = new { Username = username, Password = password };

                List<User> users = SqliteDataAccess.LoadData<User>(sql, parameters);

                if (users != null && users.Count > 0)
                {
                    User user = users.First();

                    LogLoginActivity(user.Username, user.UserId);

                    return user;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Login error: {ex.Message}");
            }
        }

        private void LogLoginActivity(string username, int userId)
        {
            try
            {
                string sql = "INSERT INTO LogActivity (Username, Aktivitas, Keterangan, CreatedAt, UserId) VALUES (@Username, @Aktivitas, @Keterangan, @CreatedAt, @UserId)";

                var parameters = new
                {
                    Username = username,
                    Aktivitas = "Login",
                    Keterangan = $"User {username} logged in",
                    CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    UserId = userId
                };

                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to log activity: {ex.Message}");
            }
        }

        public void LogLogoutActivity(string username, int userId)
        {
            try
            {
                string sql = "INSERT INTO LogActivity (Username, Aktivitas, Keterangan, CreatedAt, UserId) VALUES (@Username, @Aktivitas, @Keterangan, @CreatedAt, @UserId)";

                var parameters = new
                {
                    Username = username,
                    Aktivitas = "Logout",
                    Keterangan = $"User {username} logged out",
                    CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    UserId = userId
                };

                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to log logout activity: {ex.Message}");
            }
        }
    }
}
