using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BookingCar.Domain.Entities
{
    public class Booking
    {
        [JsonPropertyName("bookingId")]
        [DisplayName("Ключ брования")]
        public int BookingId { get; set; }

        [JsonPropertyName("carId")]
        [DisplayName("Ключ автомобиля")]
        public int CarId { get; set; }

        [JsonPropertyName("clientId")]
        [DisplayName("Ключ клиента")]
        public int ClientId { get; set; }

        [JsonPropertyName("status")]
        [DisplayName("Статус бронирования")]
        public int Status { get; set; }

        [JsonPropertyName("bookingTime")]
        [DisplayName("Время создания бронирования")]
        public int BookingTime { get; set; }

        [JsonPropertyName("bookingStart")]
        [DisplayName("Время начала поездки")]
        public DateTime BookingStart { get; set; }

        [JsonPropertyName("tariffId")]
        [DisplayName("Ключ тарифа")]
        public int TariffId { get; set; }
    }
}
