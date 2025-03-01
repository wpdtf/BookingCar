namespace BookingCar.Domain.Entities
{
    public class Incident
    {
        /// <summary>
        /// Ключ инцидента
        /// </summary>
        public int IncidentId { get; set; }

        /// <summary>
        /// Виноват клиент?
        /// </summary>
        public bool ClientGuilty { get; set; }

        /// <summary>
        /// Описание инцидента
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Номер обращения в ГАИ
        /// </summary>
        public string NomerTicket { get; set; }

        /// <summary>
        /// Ключ бронирования
        /// </summary>
        public int BookingId { get; set; }
    }
}
