using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    public enum typeTicket : byte
    {
        parterre,
        balcony,
        lodge
    }

    public class Cashbox
    {
        /// <summary>
        /// Метод возвращает тип билета (typeTicket), в качетве аргумента принимает строку
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static typeTicket FindTicket(string name)
        {
            if (String.Equals(name, "партерр"))
            {
                return typeTicket.parterre;
            }
            else if (String.Equals(name, "балкон"))
            {
                return typeTicket.balcony;
            }
            else
            {
                return typeTicket.lodge;
            }
        }

        /// <summary>
        /// Метод возвращает тип билета (string) в качестве аргумента принимает typeTicket 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string FindTicket(typeTicket type)
        {
            if (type == typeTicket.parterre)
            {
                return "Партерр";
            }
            else if (type == typeTicket.balcony)
            {
                return "Балкон";
            }
            else
            {
                return "Ложа";
            }
            
        }

        private List<Performance> performances = new List<Performance>();
        private List<Client> clients = new List<Client>();

        /// <summary>
        /// Метод возвращает список спектаклей List<Performance>
        /// </summary>
        /// <returns></returns>
        public List<Performance> GetPerformances()
        {
            return performances;
        }

        /// <summary>
        /// Метод возвращает список спектаклей List<Performance> по дате
        /// </summary>
        /// <returns></returns>
        public List<Performance> GetPerformances(DateTime date)
        {
            List<Performance> performancesOnDate = new List<Performance>();
            foreach (Performance performance in performances)
            {
                if (performance.date.Year == date.Year && performance.date.Month == date.Month && performance.date.Day == date.Day)
                {
                    performancesOnDate.Add(performance);
                }
            }
            return performancesOnDate;
        }

        /// <summary>
        /// Метод возвращает список названий всех спектаклей без повторений
        /// </summary>
        /// <returns></returns>
        public List<string> GetPerformancesName()
        {
            List<string> names = new List<string>();
            bool match = false;

            for (int i = 0; i < performances.Count(); i++)
            {
                foreach (string name in names)
                {
                    if (String.Equals(name, performances[i].name))
                    {
                        match = true;
                        break;
                    }
                }
                if (!match)
                {
                    names.Add(performances[i].name);
                }
            }
            return names;
        }

        /// <summary>
        /// Метод возвращает даты проведения спектаклей List<DateTime> по имени
        /// </summary>
        /// <param name="namePerformance"></param>
        /// <returns></returns>
        public List<DateTime> GetDateTimes(string namePerformance)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            foreach (Performance performance in performances)
            {
                if (String.Equals(performance.name, namePerformance))
                {
                    dateTimes.Add(performance.date);
                }
            }
            return dateTimes;
        }

        /// <summary>
        /// Метод возвращает список (List<Client>) всех клиентов
        /// </summary>
        /// <returns></returns>
        public List<Client> GetClients()
        {
            return clients;
        }

        /// <summary>
        /// Метод возвращает клиента (Client) по имени 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Client GetClient(string name)
        {
            foreach (Client client in clients)
            {
                if (String.Equals(client.fullName, name))
                {
                    return client;
                }
            }
            return null;
        }

        /// <summary>
        /// Метод возвращает спектакль (Performance) по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Performance SelectPerformance(int id)
        {
            return performances[id];
        }

        /// <summary>
        /// Метод возвращает спектакль (Performance) по имени и дате
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Performance SelectPerformance(string name, DateTime date)
        {
            foreach (Performance performance in performances)
            {
                if (String.Equals(performance.name.ToLower(), name.ToLower()) && performance.date.Year == date.Year 
                    && performance.date.Month == date.Month && performance.date.Day == date.Day)
                {
                    return performance;
                }
            }
            return null;
        }

        /// <summary>
        /// Метод для продажи билета (typeTicket) клиенту (Client) на спектакль (Performance)
        /// </summary>
        /// <param name="client"></param>
        /// <param name="performance"></param>
        /// <param name="type"></param>
        public void SaleTicket(Client client, Performance performance, typeTicket type)
        {
            bool checkClient = false;

            for (int i = 0; i < performances.Count; i++)
            {
                if (performances[i] == performance)
                {
                    performances[i].DeleteTicket(type);
                }
            }

            for (int i = 0; i < clients.Count(); i++)
            {
                if (clients[i] == client)
                {
                    checkClient = true;
                    clients[i].AddTicket(SwitchTicket(ref performance, type));
                }
            }

            if (checkClient == false)
            {
                clients.Add(new Client(client.fullName));
                clients.Last().AddTicket(SwitchTicket(ref performance, type));
            }
        }

        /// <summary>
        /// Метод добавляет новый спектакль (Performance)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="date"></param>
        public void AddPerformance(string name, DateTime date)
        {
            performances.Add(new Performance(name, date));
        }

        /// <summary>
        /// Метод удаляет спектакль (Performance), возвращает true, при успешном удалении
        /// </summary>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool DeletePerformance(string name, DateTime date)
        {
            for (int i = 0; i < performances.Count(); i++)
            {
                if (String.Equals(performances[i].name.ToLower(), name.ToLower()) && performances[i].date.Year == date.Year
                    && performances[i].date.Month == date.Month && performances[i].date.Day == date.Day)
                {
                    performances.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool ReturnTicket(string performanceName, DateTime date, string clientName, typeTicket type)
        {
            foreach (Client client in clients)
            {
                if (String.Equals(client.fullName, clientName))
                {
                    if (client.DeleteTicket(performanceName, date, type))
                    {
                        for (int i = 0; i < performances.Count(); i++)
                        {
                            if (String.Equals(performances[i], performanceName) && performances[i].date == date)
                            {
                                performances[i].AddTicket(type);
                                break;
                            }
                        }
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Метод возвращает билет (Ticket) для указаного спектакля и типа билета
        /// </summary>
        /// <param name="performance"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public Ticket SwitchTicket(ref Performance performance, typeTicket type)
        {
            switch (type)
            {
                case typeTicket.parterre:
                    return new Parterre(performance.name, performance.date);
                case typeTicket.balcony:
                    return new Balcony(performance.name, performance.date);
                case typeTicket.lodge:
                    return new Lodge(performance.name, performance.date);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Метод возвращает список постоянных клиентов
        /// </summary>
        /// <returns></returns>
        public List<Client> RegularClients()
        {
            List<Client> regularClients = new List<Client>();

            foreach (Client client in clients)
            {
                if (client.discount < 1)
                {
                    regularClients.Add(client);
                }
            }
            return regularClients;
        }
    }
}
