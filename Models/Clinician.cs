using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPITools.EntityMapper;
using WebAPITools.Models;

namespace Fox.Microservices.Common.Data.Models
{
	public class Clinician: ModelBase
	{
		[FieldMapper("EMPLOYEE_CODE")]
		public string Code { get; set; }
		[FieldMapper("EMPLOYEE_DESCR")]
		public string Description { get; set; }

		[FieldMapper("EMPLOYEE_TYPE_CODE")]
		public string ClinicianTypeCode { get; set; }
		public string ClinicianTypeDescription { get; set; }

		public override void LoadData<T>(DbContext context, dynamic entity)
		{
			base.LoadData<T>(context, (T)entity);

			ClinicianTypeDescription = entity?.SY_EMPLOYEE_TYPE.EMPLOYEE_TYPE_DESCR;
		}
	}
}
