using EgzamenDaw.Models.Base;
namespace EgzamenDaw.Models
{
    public class Materii : BaseEntity
    {
        //many to many
        public string NumeMaterie { get; set; }
        public ICollection<ProfesorMaterie> ProfesorMaterie { get; set; }
    }
}
