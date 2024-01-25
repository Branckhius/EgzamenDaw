namespace EgzamenDaw.Models
{
    public class ProfesorMaterie
    {
        //foreign key-ul
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }

        //foreign key-ul
        public int MaterieId { get; set; }
        public Materii Materii { get; set; }
    }
}
