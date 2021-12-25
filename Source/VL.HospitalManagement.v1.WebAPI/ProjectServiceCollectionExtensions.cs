namespace VL.HospitalManagement.v1.WebAPI
{
    using VL.HospitalManagement.v1.WebAPI.Commands;
    
    using VL.HospitalManagement.v1.WebAPI.Services;
    using VL.HospitalManagement.v1.WebAPI.ViewModels;
    using Boxed.Mapping;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// <see cref="IServiceCollection"/> extension methods add project services.
    /// </summary>
    /// <remarks>
    /// AddSingleton - Only one instance is ever created and returned.
    /// AddScoped - A new instance is created and returned for each request/response cycle.
    /// AddTransient - A new instance is created and returned each time.
    /// </remarks>
    public static class ProjectServiceCollectionExtensions
    {
        public static IServiceCollection AddProjectCommands(this IServiceCollection services) =>
            services
                
                .AddSingleton<ICalculatePatientGroupsCommand, CalculatePatientsGroupCommand>();

        
                

        

        public static IServiceCollection AddProjectServices(this IServiceCollection services) =>
            services
                .AddSingleton<IClockService, ClockService>();
    }
}
