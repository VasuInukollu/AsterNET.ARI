﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 31/08/2020 12:42:41
*/
using System;
using System.Collections.Generic;
using AsterNET.ARI.Actions;

namespace AsterNET.ARI.Models
{
	/// <summary>
	/// Info about Asterisk status
	/// </summary>
	public class StatusInfo 
	{


		/// <summary>
		/// Time when Asterisk was started.
		/// </summary>
		public DateTime Startup_time { get; set; }

		/// <summary>
		/// Time when Asterisk was last reloaded.
		/// </summary>
		public DateTime Last_reload_time { get; set; }

	}
}
