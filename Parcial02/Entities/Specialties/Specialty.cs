namespace Parcial02.Entities.Specialties
{
    public class Specialty
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public Specialty()
        {
            
        }

        public Specialty(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}