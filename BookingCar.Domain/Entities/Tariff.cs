namespace BookingCar.Domain.Entities
{
    public class Tariff
    {
        /// <summary>
        /// Ключ тарифа
        /// </summary>
        public int TariffId { get; set; }

        /// <summary>
        /// Наименование тарифа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Стоимость тарифа в час
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Описание тарифа
        /// </summary>
        public string Description { get; set; }
    }
}
