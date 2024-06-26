﻿namespace VL.HospitalManagement.v1.WebAPI.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;
    using VL.HospitalManagement.v1.WebAPI.Commands;
    using VL.HospitalManagement.v1.WebAPI.Constants;
    using VL.HospitalManagement.v1.WebAPI.ViewModels;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.JsonPatch;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Net.Http.Headers;
#if Swagger
    using Swashbuckle.AspNetCore.Annotations;
#endif



    [Route("v{api-version:apiVersion}/api")]
    [ApiController]
#if Versioning
    [ApiVersion(ApiVersionName.V1)]
#endif
    public class PatientsController : ControllerBase
    {
        /// <summary>
        /// Returns a response body with no of groups.
        /// </summary>
        /// <param name="command">The action command.</param>
        /// <param name="calculatePatientGroupsRequest">PatientGroups</param>
        /// <param name="cancellationToken">The cancellation token used to cancel the HTTP request.</param>
        /// <returns>A 200 response containing containing the total no of patient groups.
        /// </returns>
        [HttpPost("patient-groups/calculate")]
#if Swagger
        [SwaggerResponse(StatusCodes.Status200OK, "The car was created.", typeof(CalculatePatientGroupsResponse))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "The car is invalid.", typeof(ProblemDetails))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, "The car is invalid.", typeof(ProblemDetails))]
        [SwaggerResponse(StatusCodes.Status406NotAcceptable, "The MIME type in the Accept HTTP header is not acceptable.", typeof(ProblemDetails))]
        [SwaggerResponse(StatusCodes.Status415UnsupportedMediaType, "The MIME type in the Content-Type HTTP header is unsupported.", typeof(ProblemDetails))]
#endif
        public Task<IActionResult> CalcualtePatientGroups(
            [FromServices] ICalculatePatientGroupsCommand command,
            [FromBody] CalculatePatientGroupsRequest calculatePatientGroupsRequest,
            CancellationToken cancellationToken) => command.ExecuteAsync(calculatePatientGroupsRequest, cancellationToken);



    }
}
