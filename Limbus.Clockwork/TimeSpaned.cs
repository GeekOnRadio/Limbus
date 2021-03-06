﻿using System;

namespace Limbus.Clockwork
{
	public class TimeSpaned<T>
	{
		public TimeSpan Duration { get; private set; }
		public T Value { get; private set; }

		public TimeSpaned (T v, TimeSpan duration)
		{
			this.Duration = duration;
			this.Value = v;
		}
	}

	public static class TimeSpaned
	{
		public static TimeSpaned<T> Create<T>(T v, TimeSpan duration)
		{
			return new TimeSpaned<T> (v, duration);
		}

		public static TimeSpaned<T> In<T>(this T v, TimeSpan duration)
		{
			return TimeSpaned.Create<T>(v, duration);
		}
	}
}

