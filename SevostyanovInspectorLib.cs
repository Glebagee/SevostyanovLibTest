using System;
using System.Collections.Generic;

namespace InspectorLib
{
    public class FunctionInsp
    {
        // Название автоинспекции
        private const string InspectionName = "Автоинспекция г. Чита";

        // ФИО главного инспектора
        private string chiefInspectorFullName = "Васильев Василий Иванович";

        // Список сотрудников
        private List<string> workers = new List<string>
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        // Метод для получения ФИО главного инспектора
        public string GetInspector()
        {
            return chiefInspectorFullName;
        }

        // Метод для получения названия автоинспекции
        public string GetCarInspection()
        {
            return InspectionName;
        }

        // Метод для изменения ФИО главного инспектора
        public bool SetInspector(string fullname)
        {
            if (workers.Contains(fullname))
            {
                chiefInspectorFullName = fullname;
                return true; // Изменение прошло успешно
            }
            return false; // ФИО не найдено в списке сотрудников
        }

        // Метод для генерации госномера
        public string GenerateNumber(string number, string symbol, string code)
        {
            symbol = symbol.ToUpper();
            return $"{symbol}{number}_{code}";
        }

        // Метод для получения списка сотрудников
        public List<string> GetWorker()
        {
            return new List<string>(workers); // Возвращаем копию списка сотрудников
        }

        // Метод для добавления нового сотрудника
        public void AddWorker(string fullName)
        {
            if (!workers.Contains(fullName))
            {
                workers.Add(fullName); // Добавляем нового сотрудника
            }
        }
    }
}