using System;

namespace BookingCar.Domain.Entities
{
    public class ReportForClientBooking : Report
    {
        /// <summary>
        /// Ключ брования
        /// </summary>
        public int BookingId { get; set; }

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
        /// Наименование тарифа
        /// </summary>
        public string NameTariff { get; set; }

        /// <summary>
        /// Количество инцидентов по бранированию
        /// </summary>
        public int? CountIncident { get; set; }
    }
}
