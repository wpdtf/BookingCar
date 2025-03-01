using System;

namespace BookingCar.Domain.Entities
{
    public class Booking
    {
        /// <summary>
        /// Ключ брования
        /// </summary>
        public int BookingId { get; set; }

        /// <summary>
        /// Ключ автомобиля
        /// </summary>
        public int CarId { get; set; }

        /// <summary>
        /// Ключ клиента
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Статус бронирования
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Время создания бронирования
        /// </summary>
        public int BookingTime { get; set; }

        /// <summary>
        /// Время начала поездки
        /// </summary>
        public DateTime BookingStart { get; set; }

        /// <summary>
        /// Ключ тарифа
        /// </summary>
        public int TariffId { get; set; }
    }
}
