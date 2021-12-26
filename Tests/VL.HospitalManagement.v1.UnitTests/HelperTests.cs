using System;
using VL.HospitalManagement.v1.WebAPI.Helpers.BussinessLogics;
using Xunit;

namespace VL.HospitalManagement.v1.UnitTests
{
    public class HelpersTest
    {
        [Fact]
        public void Patients_Get_No_of_Groups()
        {
            //Arrange
            int[][] patientsMatrix = new int[6][] { new int[] { 1, 1, 0, 0, 0, 0 }, new int[] { 0, 1, 0, 0, 0, 0 }, new int[] { 1, 0, 1, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 1, 0 }, new int[] { 0, 0, 0, 0, 0, 1 }, new int[] { 1, 1, 0, 1, 0, 0 } };
            int expectedNumberOfGroups = 4;

            //Act
            int actualNumberOfGroups = PatientsHelper.CalculateNumberOfGroups(patientsMatrix);

            //Assert
            Assert.Equal(expectedNumberOfGroups, actualNumberOfGroups);

        }

        [Fact]
        public void Patients_Get_No_of_Groups_EmptyTest()
        {
            //Arrange
            int[][] patientsMatrix = new int[][] {  };
            int expectedNumberOfGroups = 0;

            //Act
            int actualNumberOfGroups = PatientsHelper.CalculateNumberOfGroups(patientsMatrix);

            //Assert
            Assert.Equal(expectedNumberOfGroups, actualNumberOfGroups);

        }



    }
}
