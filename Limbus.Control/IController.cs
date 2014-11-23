﻿using System;
using System.Collections.Generic;
using Limbus.Clockwork;

namespace Limbus.Control
{
	public interface IController<T> : IControllable<T>
	{
		void Update(IEnumerable<IControllable<T>> swarm);
	}
}

