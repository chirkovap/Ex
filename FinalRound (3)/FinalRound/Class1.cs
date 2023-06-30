using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalRound
{
    public static class Globals
    {
        public static int Variable;
    }
    // Класс представляет собой модель спектакля
    public class Show
    {
        // Название спектакля
        public string Title { get; private set; }

        // Словарь, где ключом является название школы, а значением - количество купленных билетов
        public Dictionary<string, int> SchoolsAndTickets { get; private set; } = new Dictionary<string, int>();

        // Конструктор для создания нового спектакля
        public Show(string title)
        {
            Title = title;
        }

        // Метод для добавления школы и количества купленных билетов в спектакль
        public void AddSchoolAndTickets(string school, int tickets)
        {
            // Если школа уже добавлена, увеличиваем количество билетов, иначе - добавляем новую запись
            if (SchoolsAndTickets.ContainsKey(school))
            {
                SchoolsAndTickets[school] += tickets;
            }
            else
            {
                SchoolsAndTickets.Add(school, tickets);
            }
        }

        // Метод для проверки, существует ли такая школа
        public bool IsContainSchool(string school)
        {
            if (SchoolsAndTickets.ContainsKey(school)) return true;
            else return false;
        }

        // Возвращает общее количество проданных билетов для данного спектакля
        public int TotalTicketsSold => SchoolsAndTickets.Values.Sum();

        // Выводит полную информацию о спектакле
        public string DisplayShow()
        {
            string str = "";
            int n = 1;
            str += ($"\nСпектакль: {Title}\r\n");
            foreach (var entry in SchoolsAndTickets)
            {
                str += ($"{n}. Школа: {entry.Key} \r\nБилетов куплено: {entry.Value}\r\n");
                n++;
            }
            str += ($"\r\nВсего билетов продано: {TotalTicketsSold}\r\n");

            return str;
        }

        // Выводит краткую информацию о спектакле (название и общее количество билетов)
        public string DisplayShowBrief()
        {
            string str = "";
            str += ($"Спектакль: {Title} Всего билетов продано: {TotalTicketsSold}\r\n");

            return str;
        }
    }

    // Класс представляет собой модель театра
    public class Theater
    {
        // Список всех спектаклей в театре
        private List<Show> shows = new List<Show>();

        // Метод для создания нового спектакля
        public void CreateShow(string title)
        {
            var show = shows.FirstOrDefault(s => s.Title == title);
            // Если спектакль с таким названием уже есть, то не создаем новый
            if (show == null)
            {
                show = new Show(title);
                shows.Add(show);
            }
        }

        // Метод для проверки, существует ли такой спектакль
        public bool IsContainShow(string title)
        {
            var show = shows.FirstOrDefault(s => s.Title == title);
            
            if (show == null) return false;
            else return true;
        }

        // Метод для добавления школы и количества купленных билетов в выбранный спектакль
        public void AddSchoolAndTickets(string title, string school, int tickets)
        {
            var show = shows.FirstOrDefault(s => s.Title == title);
            show?.AddSchoolAndTickets(school, tickets);
        }

        // Метод для вывода информации о выбранном спектакле
        public string DisplayCurrentShow(string showTitle)
        {
            string str = "";
            var show = shows.FirstOrDefault(s => s.Title == showTitle);
            str = show?.DisplayShow();
            return str;
        }

        // Метод для вывода краткой информации обо всех спектаклях, отсортированных по количеству проданных билетов и названию
        public string DisplayShows()
        {
            var sortedShows = shows.OrderByDescending(s => s.TotalTicketsSold).ThenBy(s => s.Title);
            string str = "";
            int n = 1;
            foreach (Show show in sortedShows)
            {
                str += $"{n}. " + show.DisplayShowBrief();
                n ++;
            }
            return str;
        }
    }
}
