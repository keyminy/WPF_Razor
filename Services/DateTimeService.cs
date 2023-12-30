using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiDesktopApp1.Interfaces;

namespace UiDesktopApp1.Services
{
	internal class DateTimeService : IDateTime
	{
		public DateTime? GetCurrentTime()
		{
			//현재 시간 return
			return DateTime.Now;
		}
	}
}
