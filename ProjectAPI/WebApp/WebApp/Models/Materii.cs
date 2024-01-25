using WebApp.Models.Base;

namespace WebApp.Models
{
	public class Materii : BaseEntity
	{
		public string? Name { get; set; }

        public ICollection<ModelRelation>? ModelsRelations { get; set; }
    }
}

