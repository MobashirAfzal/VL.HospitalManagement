namespace VL.HospitalManagement.v1.WebAPI.Commands
{
    using VL.HospitalManagement.v1.WebAPI.ViewModels;
    using Boxed.AspNetCore;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading;

    public interface ICalculatePatientGroupsCommand : IAsyncCommand<CalculatePatientGroupsRequest>
    {
        
    }
}
