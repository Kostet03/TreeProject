using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TreeProject.Models;

namespace TreeProject.Services
{
    public static class RandomGenerator
    {
        static Random random = new Random();

        public static Node GenerateRandomNode(Node parent = null)
        {
            return new Node
            {
                Key = Guid.NewGuid(),
                FIO = string.Format("{0} {1} {2}", GetRandomItem<string>(LastNames), GetRandomItem<string>(FirstNames), GetRandomItem<string>(SecondNames)),
                Birthday = GetRandomDate(),
                City = GetRandomItem<string>(Cities),
                Street = GetRandomItem<string>(Streets),
                House = GetRandomItem<int>(Houses),
                Level = GetRandomItem<int>(Houses),
                Parent = parent,
                Nodes = new ObservableCollection<Node>()
            };
        }

        public static T GetRandomItem<T>(List<T> items)
        {
            var item = items[random.Next(items.Count)];
            return item;
        }

        public static DateTime GetRandomDate()
        {
            var startDate = new DateTime(1950, 1, 1);
            var endDate = new DateTime(2005, 12, 31);
            int range = (endDate - startDate).Days;
            return startDate.AddDays(random.Next(range));
        }


        #region Lists

        public static List<string> Cities = new List<string>
        {
            "Минск",
            "Брест",
            "Гомель",
            "Гродно",
            "Могилев",
            "Витебск",
            "Кобрин",
            "Барановичи",
            "Бобруйск",
            "Кировск",
            "Новогрудок",
            "Лида",
            "Борисов",
            "Логойск",
            "Солигорск"
        };

        public static List<string> Streets = new List<string>()
        {
            "Первомайская",
            "Ракитная",
            "Мележа",
            "Логойский тракт",
            "Победителей",
            "Независимости",
            "Хмельницкого",
            "П.Бровки",
            "Октябрьская",
            "Немига",
            "Краснозвездная",
            "Чкалова",
            "Ленина",
            "Багратиона",
            "Держинская",
            "Гоголя",
            "Калинина"
        };

        public static List<int> Houses = new List<int>
        {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30,
            31,
            32,
            33,
            34,
            35,
            36,
            37,
            38,
            39
        };

        public static List<string> LastNames = new List<string>()
        {
            "Петров",
            "Иванов",
            "Федоров",
            "Мухин",
            "Крылов",
            "Николаев",
            "Калинин",
            "Миронов",
            "Попов",
            "Смирнов",
            "Сидоров",
            "Архипов",
            "Воронин",
            "Карпов",
            "Лазарев",
            "Сергеев"
        };
        public static List<string> SecondNames = new List<string>()
        {
            "Юрьевич",
            "Сергеевич",
            "Антонович",
            "Константинович",
            "Александрович",
            "Игоревич",
            "Владиславович",
            "Васильевич",
            "Максимович",
            "Олегович",
            "Леонидович",
            "Романович",
            "Егорович",
            "Андреевич"
        };
        public static List<string> FirstNames = new List<string>()
        {
            "Александр",
            "Дмитрий",
            "Максим",
            "Сергей",
            "Андрей",
            "Алексей",
            "Илья",
            "Кирилл",
            "Михаил",
            "Денис",
            "Евгений",
            "Даниил",
            "Константин",
            "Антон",
            "Николай",
            "Юрий"
        };
        #endregion
    }
}
