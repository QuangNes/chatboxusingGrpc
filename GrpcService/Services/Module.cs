using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GrpcService.Services
{
    public class Module
    {
        public class GlobalVariables
        {
            // Biến toàn cục được khai báo ở mức đỉnh của lớp
            public static string nameOfUser = "";
            public static bool receiveMess = false;
        }

        public static bool IsUseName_PasswordCorrect(string username, string password)
        {
            // Kiểm tra xem tên người dùng và mật khẩu có tồn tại trong tệp hay không
            string filePath = "users.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                    {
                        return true; // Tên người dùng và mật khẩu đúng
                    }
                }
            }

            return false; // Tên người dùng hoặc mật khẩu không đúng
        }

        public static bool IsUserExist(string username)
        {
            // Kiểm tra xem tên người dùng đã tồn tại trong tệp hay chưa
            string filePath = "users.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2 && parts[0] == username)
                    {
                        return true; // Tên người dùng đã tồn tại
                    }
                }
            }

            return false; // Tên người dùng chưa tồn tại
        }

        public static bool IsPasswordCorrect(string password)
        {
            // Kiểm tra xem tên người dùng đã tồn tại trong tệp hay chưa
            string filePath = "users.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2 && parts[1] == password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static void SaveUser(string username, string password)
        {
            // Lưu thông tin người dùng vào tệp
            string filePath = "users.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{username}:{password}");
            }
        }

        public static void WriteListToFile(string filePath, string listName)
        {
            try
            {
                // Mở tệp để ghi
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Ghi chuỗi ListName vào tệp
                    writer.WriteLine(listName);
                }
            }
            catch (Exception ex) { }
        }

        public static void ReadFileToList(string filePath, string[] listString)
        {
            try
            {
                // Kiểm tra xem tệp tồn tại
                if (File.Exists(filePath))
                {
                    // Đọc toàn bộ nội dung từ tệp và chia thành mảng các chuỗi
                    string content = File.ReadAllText(filePath);
                    string[] lines = content.Split(' ');

                    // Sao chép các phần tử từ mảng lines vào mảng listString
                    Array.Copy(lines, listString, Math.Min(lines.Length, listString.Length));
                }
            }
            catch (Exception ex) { }
        }

        public static string ReadFileMess(string filePath)
        {
            try
            {
                // Kiểm tra xem tệp tồn tại
                if (File.Exists(filePath))
                {
                    // Đọc toàn bộ nội dung từ tệp và trả về giá trị
                    return File.ReadAllText(filePath);
                }
                else
                {
                    // Nếu tệp không tồn tại, trả về chuỗi rỗng
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                return string.Empty;
            }
        }

    }
}
