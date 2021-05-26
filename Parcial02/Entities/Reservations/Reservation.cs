namespace Parcial02.Entities.Reservations
{
    public class Reservation
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int SpecialtyId { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }


        public Reservation()
        {
            
        }


        public Reservation(int userId, int specialtyId, string date, string time)
        {
            UserId = userId;
            SpecialtyId = specialtyId;
            Date = date;
            Time = time;
        }
    }
}