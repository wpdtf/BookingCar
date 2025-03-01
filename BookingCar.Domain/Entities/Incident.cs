using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BookingCar.Domain.Entities
{
    public class Incident
    {
        [JsonPropertyName("IncidentId")]
        [DisplayName("Ключ инцидента")]
        public int IncidentId { get; set; }

        [JsonPropertyName("ClientGuilty")]
        [DisplayName("Виноват клиент?")]
        public bool ClientGuilty { get; set; }

        [JsonPropertyName("Description")]
        [DisplayName("Описание инцидента")]
        public string Description { get; set; }

        [JsonPropertyName("NomerTicket")]
        [DisplayName("Номер обращения в ГАИ")]
        public string NomerTicket { get; set; }

        [JsonPropertyName("BookingId")]
        [DisplayName("Ключ бронирования")]
        public int BookingId { get; set; }
    }
}
