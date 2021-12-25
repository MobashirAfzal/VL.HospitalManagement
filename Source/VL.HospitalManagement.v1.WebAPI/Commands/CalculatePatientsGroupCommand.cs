namespace VL.HospitalManagement.v1.WebAPI.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using VL.HospitalManagement.v1.WebAPI.Constants;
    
    using VL.HospitalManagement.v1.WebAPI.ViewModels;
    using Boxed.Mapping;
    using Microsoft.AspNetCore.Mvc;

    public class CalculatePatientsGroupCommand : ICalculatePatientGroupsCommand
    {
        

        public CalculatePatientsGroupCommand()
            
        {
            
        }

        public Task<IActionResult> ExecuteAsync(PatientGroupsRequest parameter, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        
    }
}
