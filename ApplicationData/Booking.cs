//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR4_UP.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int IdBooking { get; set; }
        public int IDGuests { get; set; }
        public string PhoneGuest { get; set; }
        public System.DateTime DateOfArrival { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public string Category { get; set; }
    }
}
