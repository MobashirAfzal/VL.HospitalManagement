using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VL.HospitalManagement.v1.WebAPI.Helpers.BussinessLogics
{
    public class PatientsHelper
    {
		

		static void DepthFirstSearch(int[][] patientMatrix, int i, int j, int noOfRows, int noOfColumns)
		{


			if (i < 0 || j < 0 || i > (noOfRows - 1) || j > (noOfColumns - 1) || patientMatrix[i][j] != 1)
			{
				return;
			}

			if (patientMatrix[i][j] == 1)
			{
				patientMatrix[i][j] = 0;
				DepthFirstSearch(patientMatrix, i + 1, j, noOfRows, noOfColumns);  //right traversal
				DepthFirstSearch(patientMatrix, i - 1, j, noOfRows, noOfColumns);  //left traversal
				DepthFirstSearch(patientMatrix, i, j + 1, noOfRows, noOfColumns);  //upward traversal
				DepthFirstSearch(patientMatrix, i, j - 1, noOfRows, noOfColumns);  //downward traversal
				DepthFirstSearch(patientMatrix, i + 1, j + 1, noOfRows, noOfColumns); //upward-right traversal
				DepthFirstSearch(patientMatrix, i - 1, j - 1, noOfRows, noOfColumns); //downward-left traversal
				DepthFirstSearch(patientMatrix, i + 1, j - 1, noOfRows, noOfColumns); //downward-right traversal
				DepthFirstSearch(patientMatrix, i - 1, j + 1, noOfRows, noOfColumns); //upward-left traversal
			}
		}

		public static int CalculateNumberOfGroups(int[][] patientMatrix)
		{
			int noOfRows = patientMatrix.Length;

			int count = 0;
			for (int i = 0; i < noOfRows; i++)
			{
				int noOfColumns = patientMatrix[0].Length;
				for (int j = 0; j < noOfColumns; j++)
				{
					if (patientMatrix[i][j] == 1)
					{
						patientMatrix[i][j] = 0;
						count++;
						DepthFirstSearch(patientMatrix, i + 1, j, noOfRows, noOfColumns);  //right traversal
						DepthFirstSearch(patientMatrix, i - 1, j, noOfRows, noOfColumns);  //left traversal
						DepthFirstSearch(patientMatrix, i, j + 1, noOfRows, noOfColumns);  //upward traversal
						DepthFirstSearch(patientMatrix, i, j - 1, noOfRows, noOfColumns);  //downward traversal
						DepthFirstSearch(patientMatrix, i + 1, j + 1, noOfRows, noOfColumns); //upward-right traversal
						DepthFirstSearch(patientMatrix, i - 1, j - 1, noOfRows, noOfColumns); //downward-left traversal
						DepthFirstSearch(patientMatrix, i + 1, j - 1, noOfRows, noOfColumns); //downward-right traversal
						DepthFirstSearch(patientMatrix, i - 1, j + 1, noOfRows, noOfColumns); //upward-left traversal
					}
				}
			}
			return count;
		}

	}
}
