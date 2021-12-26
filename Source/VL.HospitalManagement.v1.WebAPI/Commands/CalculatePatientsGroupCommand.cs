namespace VL.HospitalManagement.v1.WebAPI.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using VL.HospitalManagement.v1.WebAPI.Constants;
    
    using VL.HospitalManagement.v1.WebAPI.ViewModels;
    using Boxed.Mapping;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using Boxed.AspNetCore;

    public class CalculatePatientsGroupCommand : ICalculatePatientGroupsCommand
    {





#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IActionResult> ExecuteAsync(CalculatePatientGroupsRequest request, CancellationToken cancellationToken)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {




            //Please refer the Helpers for implementation.

            int numOfGroups = Helpers.BussinessLogics.PatientsHelper.CalculateNumberOfGroups(request.matrix);
            var calculatePatientGroupsResponseBody = new CalculatePatientGroupsResponse
            {
                NumberOfGroups = numOfGroups
            };

            

            return new OkObjectResult(calculatePatientGroupsResponseBody);




        }


    }
}
