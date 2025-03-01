namespace BookingCar.Domain.Entities
{
    public class Car
    {
        /// <summary>
        /// Ключ автомобиля
        /// </summary>
        public int CarId { get; set; }

        /// <summary>
        /// брэнд
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Марка
        /// </summary>
        public string Mark { get; set; }

        /// <summary>
        /// Год производитства
        /// </summary>
        public int YearStart { get; set; }

        /// <summary>
        /// Цвеь
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Номер автомобиля
        /// </summary>
        public string CarNumber { get; set; }

        /// <summary>
        /// Вин номер автомобиля
        /// </summary>
        public string VIN { get; set; }

        /// <summary>
        /// Активен ли автомобиль
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Минимальный стаж автомобиля
        /// </summary>
        public int MinimalExperience { get; set; }

        /// <summary>
        /// Класс автомобиля
        /// </summary>
        public int Class { get; set; }

        /// <summary>
        /// Класс автомобиля (текстом)
        /// </summary>
        public string ClassTxt { get; set; }
    }
}
