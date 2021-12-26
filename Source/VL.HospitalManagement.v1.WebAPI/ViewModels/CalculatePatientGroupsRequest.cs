namespace VL.HospitalManagement.v1.WebAPI.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    //public class CalculatePatientGroupsRequest
    //{
    //    [Required]
    //    public List<List<int>> matrix { get; set; }
    //}


    public class CalculatePatientGroupsRequest
    {
        [Required]
        public int[][] matrix { get; set; }
    }




}


