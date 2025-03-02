using System.ComponentModel.DataAnnotations;

namespace BookingCar.Domain.Declare {
    public enum statusBooking
    {
        [Display(Name = "Создан")]
        Create = 1,

        [Display(Name = "Оплачен")]
        Payment = 2,

        [Display(Name = "Отменен")]
        Сancellation = 3,

        [Display(Name = "Завершен")]
        End = 4
    }
}
