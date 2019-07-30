using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_3_Static_Interface
{
    public partial class Practice
    {
        /// <summary>
        /// AL3-P1/3. Создать класс UniqueItem c числовым полем Id. 
        /// Каждый раз, когда создается новый экземпляр данного класса, 
        /// его идентификатор должен увеличиваться на 1 относительно последнего созданного. 
        /// Приложение должно поддерживать возможность начать идентификаторы с любого числа. 
        /// </summary>
        public static void AL3_P1_3()
        {
            for (int i = 0; i < 100; i++)
            {
                UniqueItem oItem = new UniqueItem();
            }

            Console.WriteLine(UniqueItem.Id);
        }

        /// <summary>
        /// AL3-P2/3. Отредактировать консольное приложение Printer. 
        /// Заменить базовый абстрактный класс на интерфейс.
        /// </summary>
        public static void AL3_P2_3()
        {

        }


        /// <summary>
        /// AL3-P3/3. Создайте обобщенный метод GuessType<T>(T item), 
        /// который будет принимать переменную обобщенного типа и выводить на консоль, 
        /// что это за тип был передан.
        /// </summary>
        public static void GuessType<T>(T item)
        {
            Type type = item.GetType();
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.String:
                    Console.WriteLine($"Вы передали строку длинной {item.ToString().Length} символов.");
                    break;
                case TypeCode.Int32 when Convert.ToInt32(item) > 0:
                    Console.WriteLine("Вы передали положительное целое число.");
                    break;
                case TypeCode.Double:
                    Console.WriteLine($"Вы передали вещественное число с {(Math.Abs(Convert.ToDecimal(item))).ToString().Length-1} значимыми цифрами.");
                    break;
                case TypeCode.DateTime:
                    Console.WriteLine("Вы передали время");
                    break;
                default:
                    Console.WriteLine("Понятия не имею, что вы передали.");
                    break;
            }
        }
    }

    public class UniqueItem
    {
        public static int Id { get; private set; }

        public UniqueItem()
        {
            Id++;
        }

        static UniqueItem()
        {
            Id = 1000;
        }
    }
}
