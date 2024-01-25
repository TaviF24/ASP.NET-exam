using WebApp.Models.Enums;
using WebApp.Models.Base;

namespace WebApp.Models
{
	public class Profesori : BaseEntity
	{
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public int Salariu { get; set; }

        public Role Role { get; set; }

        public ICollection<ModelRelation>? ModelsRelations { get; set; }
    }
}

