namespace BookingCar.Domain.Entities
{
    public class TariffCar
    {
        /// <summary>
        /// Ключ автомобиля
        /// </summary>
        public int CarId { get; set; }

        /// <summary>
        /// Ключ тарифа
        /// </summary>
        public int TariffId { get; set; }
    }
}
