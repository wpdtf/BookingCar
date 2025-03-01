using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BookingCar.Domain.Entities
{
    public class Staff
    {
        /// <summary>
        /// Логин сотрудника
        /// </summary>
        [JsonPropertyName("userId")]
        [DisplayName("Ключ сотрудника")]
        public int UserId { get; set; }

        /// <summary>
        /// Логин сотрудника
        /// </summary>
        [JsonPropertyName("last_name")]
        [DisplayName("Фамилия")]
        public string Last_name { get; set; }

        /// <summary>
        /// Логин сотрудника
        /// </summary>
        [JsonPropertyName("first_name")]
        [DisplayName("Имя")]
        public string First_name { get; set; }

        /// <summary>
        /// Логин сотрудника
        /// </summary>
        [JsonPropertyName("middle_name")]
        [DisplayName("Отчество")]
        public string Middle_name { get; set; }

        /// <summary>
        /// Логин сотрудника
        /// </summary>
        [JsonPropertyName("phone")]
        [DisplayName("Телефон")]
        public string Phone { get; set; }

        /// <summary>
        /// Логин сотрудника
        /// </summary>
        [JsonPropertyName("birthdate")]
        [DisplayName("Дата рождения")]
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// Логин сотрудника
        /// </summary>
        [JsonPropertyName("dismissed")]
        [DisplayName("Уволен?")]
        public bool Dismissed { get; set; }

        /// <summary>
        /// Логин сотрудника
        /// </summary>
        [JsonPropertyName("position")]
        [DisplayName("Ключ должности")]
        public short Position { get; set; }

        /// <summary>
        /// Логин сотрудника
        /// </summary>
        [JsonPropertyName("positionTxt")]
        [DisplayName("Должность сотрудника")]
        public string PositionTxt { get; set; }
    }
}
