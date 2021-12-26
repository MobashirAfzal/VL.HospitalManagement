namespace VL.HospitalManagement.v1.WebAPI.Commands
{
    using VL.HospitalManagement.v1.WebAPI.ViewModels;
    using Boxed.AspNetCore;
    

    public interface ICalculatePatientGroupsCommand : IAsyncCommand<CalculatePatientGroupsRequest>
    {
        
    }
}
