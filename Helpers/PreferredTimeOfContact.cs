using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using WebAPITools.Helpers;

namespace Fox.Microservices.Common.Data.Helpers
{
	public enum PreferredTimeOfContact
	{
		[EnumValue("02")]
		[Description("9am-12pm")]
		Morning,

		[EnumValue("03")]
		[Description("12pm-3pm")]
		EarlyAfternoon,

		[EnumValue("04")]
		[Description("3pm-6pm")]
		Afternoon,

		[EnumValue("05")]
		[Description("after 6pm")]
		Evening,

		[EnumValue("06")]
		[Description("No Preferences")]
		NoPreference
	}
}
