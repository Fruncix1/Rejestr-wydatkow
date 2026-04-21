using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace RejestrWydatkow
{
    public static class FileHelper
    {
        private static readonly string filePath = "expenses.json";

        public static List<Expense> LoadExpenses()
        {
            if (!File.Exists(filePath))
                return new List<Expense>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Expense>>(json)
                   ?? new List<Expense>();
        }

        public static void SaveExpenses(List<Expense> expenses)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(expenses, options);
            File.WriteAllText(filePath, json);
        }

        public static void Save(List<Expense> expenses)
        {
            string json = JsonSerializer.Serialize(expenses);
            File.WriteAllText(filePath, json);
        }

        public static List<Expense> Load()
        {
            if (!File.Exists(filePath))
                return new List<Expense>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Expense>>(json)
                   ?? new List<Expense>();
        }
    }
}