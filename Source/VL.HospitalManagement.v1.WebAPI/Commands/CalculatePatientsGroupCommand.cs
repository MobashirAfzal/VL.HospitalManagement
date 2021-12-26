namespace VL.HospitalManagement.v1.WebAPI.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using VL.HospitalManagement.v1.WebAPI.Constants;
    
    using VL.HospitalManagement.v1.WebAPI.ViewModels;
    using Boxed.Mapping;
    using Microsoft.AspNetCore.Mvc;
    using System;

    public class CalculatePatientsGroupCommand : ICalculatePatientGroupsCommand
    {
        

        public CalculatePatientsGroupCommand()
            
        {
            
        }

        public Task<IActionResult> ExecuteAsync(CalculatePatientGroupsRequest request, CancellationToken cancellationToken = default)
        {

            int numOfGroups = Helpers.BussinessLogics.Patients.CalculateNumberOfGroups(request.matrix);
            var calculatePatientGroupsResponseBody = new CalculatePatientGroupsResponse
            {
                NumberOfGroups = numOfGroups
            };

            throw new Exception();


        }

        
    }
}
