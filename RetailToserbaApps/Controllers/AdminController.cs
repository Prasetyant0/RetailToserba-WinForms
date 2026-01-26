using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailToserbaApps.Data;
using RetailToserbaApps.Models;

namespace RetailToserbaApps.Controllers
{
    public class AdminController
    {
        public List<User> GetAllUsers()
        {
            try
            {
                string sql = "SELECT * FROM Users ORDER BY UserId DESC";
                return SqliteDataAccess.LoadData<User>(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load users: {ex.Message}");
            }
        }

        public List<User> SearchUsers(string searchTerm)
        {
            try
            {
                string sql = "SELECT * FROM Users WHERE Nama LIKE @Search OR Username LIKE @Search ORDER BY UserId DESC";
                var parameters = new { Search = $"%{searchTerm}%" };
                return SqliteDataAccess.LoadData<User>(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to search users: {ex.Message}");
            }
        }

        public User GetUserById(int userId)
        {
            try
            {
                string sql = "SELECT * FROM Users WHERE UserId = @UserId";
                var parameters = new { UserId = userId };
                List<User> result = SqliteDataAccess.LoadData<User>(sql, parameters);
                return result.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load user: {ex.Message}");
            }
        }

        public void InsertUser(User user)
        {
            try
            {
                string sql = @"INSERT INTO Users (Nama, Username, Password, Role, NoTelepon, Status, CreatedAt) 
                              VALUES (@Nama, @Username, @Password, @Role, @NoTelepon, @Status, @CreatedAt)";

                var parameters = new
                {
                    user.Nama,
                    user.Username,
                    user.Password,
                    user.Role,
                    user.NoTelepon,
                    Status = "Active",
                    CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                };

                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to insert user: {ex.Message}");
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                string sql = @"UPDATE Users SET Nama = @Nama, Username = @Username, Password = @Password, 
                              Role = @Role, NoTelepon = @NoTelepon, Status = @Status WHERE UserId = @UserId";

                var parameters = new
                {
                    user.UserId,
                    user.Nama,
                    user.Username,
                    user.Password,
                    user.Role,
                    user.NoTelepon,
                    user.Status
                };

                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update user: {ex.Message}");
            }
        }

        public void DeleteUser(int userId)
        {
            try
            {
                string sql = "DELETE FROM Users WHERE UserId = @UserId";
                var parameters = new { UserId = userId };
                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete user: {ex.Message}");
            }
        }

        public void DeactivateUser(int userId)
        {
            try
            {
                string sql = "UPDATE Users SET Status = 'Inactive' WHERE UserId = @UserId";
                var parameters = new { UserId = userId };
                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to deactivate user: {ex.Message}");
            }
        }

        public void ActivateUser(int userId)
        {
            try
            {
                string sql = "UPDATE Users SET Status = 'Active' WHERE UserId = @UserId";
                var parameters = new { UserId = userId };
                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to activate user: {ex.Message}");
            }
        }

        public bool IsUsernameExists(string username, int? excludeUserId = null)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                
                if (excludeUserId.HasValue)
                {
                    sql += " AND UserId != @UserId";
                }

                var parameters = excludeUserId.HasValue 
                    ? new { Username = username, UserId = excludeUserId.Value }
                    : (object)new { Username = username };

                var count = SqliteDataAccess.LoadData<int>(sql, parameters).FirstOrDefault();
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to check username: {ex.Message}");
            }
        }

        public List<LogActivity> GetAllLogActivities()
        {
            try
            {
                string sql = "SELECT * FROM LogActivity ORDER BY ActivityId DESC";
                return SqliteDataAccess.LoadData<LogActivity>(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load activity logs: {ex.Message}");
            }
        }

        public List<LogActivity> SearchLogActivities(string searchTerm)
        {
            try
            {
                string sql = @"SELECT * FROM LogActivity 
                              WHERE Username LIKE @Search OR Aktivitas LIKE @Search OR Keterangan LIKE @Search 
                              ORDER BY ActivityId DESC";
                var parameters = new { Search = $"%{searchTerm}%" };
                return SqliteDataAccess.LoadData<LogActivity>(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to search activity logs: {ex.Message}");
            }
        }

        // FIX BUG #2: Get logs by specific date (ignoring time component)
        public List<LogActivity> GetLogsByDate(DateTime selectedDate)
        {
            try
            {
                // Use SQLite's date() function to compare only the date part
                // This fixes the issue where datetime includes time component
                string sql = @"SELECT * FROM LogActivity 
                              WHERE date(CreatedAt) = date(@SelectedDate) 
                              ORDER BY ActivityId DESC";
                
                // Format date as yyyy-MM-dd for SQLite
                var parameters = new { SelectedDate = selectedDate.ToString("yyyy-MM-dd") };
                
                return SqliteDataAccess.LoadData<LogActivity>(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load logs by date: {ex.Message}");
            }
        }

        public List<LogActivity> GetLogActivitiesByUser(int userId)
        {
            try
            {
                string sql = "SELECT * FROM LogActivity WHERE UserId = @UserId ORDER BY ActivityId DESC";
                var parameters = new { UserId = userId };
                return SqliteDataAccess.LoadData<LogActivity>(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load user activity logs: {ex.Message}");
            }
        }

        public Dictionary<string, int> GetDashboardStatistics()
        {
            try
            {
                var stats = new Dictionary<string, int>();

                string sqlTotalUsers = "SELECT COUNT(*) FROM Users WHERE Status = 'Active'";
                stats["TotalUsers"] = SqliteDataAccess.LoadData<int>(sqlTotalUsers).FirstOrDefault();

                string sqlTotalProducts = "SELECT COUNT(*) FROM Barang";
                stats["TotalProducts"] = SqliteDataAccess.LoadData<int>(sqlTotalProducts).FirstOrDefault();

                string sqlLowStock = "SELECT COUNT(*) FROM Barang WHERE StokTersedia <= StokMinimum";
                stats["LowStock"] = SqliteDataAccess.LoadData<int>(sqlLowStock).FirstOrDefault();

                string sqlTotalTransactions = "SELECT COUNT(*) FROM Transaksi";
                stats["TotalTransactions"] = SqliteDataAccess.LoadData<int>(sqlTotalTransactions).FirstOrDefault();

                string sqlTotalLogs = "SELECT COUNT(*) FROM LogActivity";
                stats["TotalLogs"] = SqliteDataAccess.LoadData<int>(sqlTotalLogs).FirstOrDefault();

                return stats;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load dashboard statistics: {ex.Message}");
            }
        }
    }
}
