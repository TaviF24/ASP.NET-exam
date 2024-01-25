//using Lab4_23.Repositories.StudentRepository;
//using Lab4_23.Repositories.UserRepository;
//using Lab4_23.Services.UserService;

//namespace Lab4_23.Helpers.Extensions	// in loc sa scriem totul in program.cs, scriem aici serviciile/repo-urile pe care le adaugam
//{
//	public static class ServiceExtensions
//	{
//		public static IServiceCollection AddRepositories(this IServiceCollection services)
//		{
//			services.AddTransient<IUserRepository, UserRepository>();
//			services.AddTransient<IStudentRepository, StudentRepository>();
			 
//			return services;
//		}

//		public static IServiceCollection AddServices(this IServiceCollection services)
//		{
//			services.AddTransient<IUserService, UserService>();
//			return services;
//		}
//	}
//}

