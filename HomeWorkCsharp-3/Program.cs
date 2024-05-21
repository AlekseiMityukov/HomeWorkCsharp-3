using System.Net;
using HomeWorkCsharp_3.Classes;

namespace HomeWorkCsharp_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Goods> goods = new List<Goods>();
            goods.Add(new Goods() { id = 1, name =  "iphone 15", price = 799, amount = 12, category = "smartphone", description = "Dynamic Island bubbles up alerts and Live Activities — so you don’t miss them while you’re doing something else. You can track your next ride, see who’s calling, check your flight status, and so much more." });
            goods.Add(new Goods() { id = 2, name = "Samsung Galaxy S24", price = 1100, amount = 5, category = "smartphone", description = "Самый быстрый процессор в истории Galaxy. Мощнейший процессор Snapdragon 8 Gen3 специально модифицировали для смартфонов Galaxy, сделав его ещё быстрее и эффективнее. Всё это обеспечивает Samsung Galaxy S24 Ultra молниеносную скорость работы и запас производительности на годы вперёд." });
            goods.Add(new Goods() { id = 3, name = "AirPods Pro", price = 269, amount = 20, category = "headphones", description = "Наушники TWS Apple Airpods 2 – фирменное устройство для техники одноименного бренда, обеспечивающее превосходным качеством звука с объемностью и сбалансированными частотами. Особенностью этой модели является длительная автономная работа как в режиме прослушивания музыки, так и в режиме разговора. " });
            goods.Add(new Goods() { id = 4, name = "Samsung Galaxy Buds2 Pro", price = 150, amount = 35, category = "headphones", description = "Музыка в её первозданном виде, без проводов.Новая функция «Маршрут тренировки» позволяет импортировать маршруты для ходьбы и велоспорта в формате GPX со смартфона на Galaxy Watch5 Pro. Пройдите дистанцию, активируйте функцию «Вернуться» для того, чтобы вернуться точно в то же самое место, с которого вы начали движение. " });
            goods.Add(new Goods() { id = 5, name = "Apple Watch SE 2023", price = 450, amount = 28, category = "smartWatch", description = "Смарт-часы Apple Watch SE 2023 40mm оснащены гибким силиконовым ремешком и квадратным сенсорным дисплеем с технологией OLED. Алюминиевый корпус устройства выдерживает неблагоприятные воздействия благодаря водонепроницаемости 5 Бар и прочности. Интегрированные датчики обеспечивают высокую точность определения параметров здоровья и физической деятельности." });
            goods.Add(new Goods() { id = 6, name = "Samsung Galaxy Watch6 Classic", price = 400, amount = 46, category = "smartWatch", description = "Samsung Galaxy Watch6 Classic сочетают передовые технологии и классическую, проверенную временем эстетику. Стильный металлический корпус и тонкий вращающийся безель вызывают ассоциации с премиальными механическими часами, делая Watch6 Classic элегантным аксессуаром, который хорошо гармонирует с любым костюмом." });

            List<Goods> newGoods1 = goods.Where(x => x.price > 500).ToList();
            List<Goods> newGoods2 = goods.Where(x => x.category == "headphones").ToList();
            List<Goods> newGoods3 = goods.Where(x => x.name == "iphone 15").ToList();
            List<Goods> newGoods4 = goods.Where(x => x.price > 300 && x.price < 700).ToList();
            int page = 0;
            int count = 2;
            var newGoods5 = goods.Where(x => x.amount > 1).Skip(page * count).Take(count);
            foreach (var item in newGoods5)
            {
                Console.WriteLine(item.name);
            }
            page = 1;
            newGoods5 = goods.Where(x => x.amount > 1).Skip(page * count).Take(count);
            foreach (var item in newGoods5)
            {
                Console.WriteLine(item.name);
            }







        }

    }
}
