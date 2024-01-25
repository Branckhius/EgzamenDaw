using EgzamenDaw.Models.Base;
namespace EgzamenDaw.Models
{
    public class Profesor : BaseEntity
    {
        public string TipProfesor { get; set; }

        //many to many
        public ICollection<ProfesorMaterie> ProfesorMaterie { get; set; }
    }
}
