﻿using System;

namespace Highway.Data.Interceptors.Events
{
	/// <summary>
	/// Intercepts after a command execute
	/// </summary>
	public class AfterCommand : EventArgs
	{
		public ICommand Command { get; set; }

		public AfterCommand(ICommand command)
		{
			Command = command;
		}
	}
}