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
	/// Dialing state has changed.
	/// </summary>
	public class DialEvent  : Event
	{


		/// <summary>
		/// The calling channel.
		/// </summary>
		public Channel Caller { get; set; }

		/// <summary>
		/// The dialed channel.
		/// </summary>
		public Channel Peer { get; set; }

		/// <summary>
		/// Forwarding target requested by the original dialed channel.
		/// </summary>
		public string Forward { get; set; }

		/// <summary>
		/// Channel that the caller has been forwarded to.
		/// </summary>
		public Channel Forwarded { get; set; }

		/// <summary>
		/// The dial string for calling the peer channel.
		/// </summary>
		public string Dialstring { get; set; }

		/// <summary>
		/// Current status of the dialing attempt to the peer.
		/// </summary>
		public string Dialstatus { get; set; }

	}
}
