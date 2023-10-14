using System;
using System.Runtime.CompilerServices;

namespace SteamworksNative
{
	public abstract class Callback
	{
		public abstract bool IsGameServer { get; }

		internal abstract Type GetCallbackType();

		internal abstract void OnRunCallback(IntPtr pvParam);

		internal abstract void SetUnregistered();
	}
	public sealed class Callback<T> : Callback, IDisposable
	{
		public delegate void DispatchDelegate(T param);

		private bool m_bGameServer;

		private bool m_bIsRegistered;

		private bool m_bDisposed;

		public override bool IsGameServer => false;

		private event DispatchDelegate m_Func
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static Callback<T> Create(DispatchDelegate func)
		{
			return null;
		}

		public static Callback<T> CreateGameServer(DispatchDelegate func)
		{
			return null;
		}

		public Callback(DispatchDelegate func, bool bGameServer = false)
		{
		}

		~Callback()
		{
		}

		public void Dispose()
		{
		}

		public void Register(DispatchDelegate func)
		{
		}

		public void Unregister()
		{
		}

		internal override Type GetCallbackType()
		{
			return null;
		}

		internal override void OnRunCallback(IntPtr pvParam)
		{
		}

		internal override void SetUnregistered()
		{
		}
	}
}
