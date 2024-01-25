namespace WebApp.Models
{
	public class ModelRelation 
	{
		public Guid MateriiId { get; set; }
		public Materii? Materii { get; set; }

        public Guid ProfesoriId { get; set; }
        public Profesori Profesori { get; set; }
	}
}

