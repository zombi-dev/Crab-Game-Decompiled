using System;
using System.Runtime.CompilerServices;

namespace SteamworksNative
{
	public abstract class CallResult
	{
		internal abstract Type GetCallbackType();

		internal abstract void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall);

		internal abstract void SetUnregistered();
	}
	public sealed class CallResult<T> : CallResult, IDisposable
	{
		public delegate void APIDispatchDelegate(T param, bool bIOFailure);

		private SteamAPICall_t m_hAPICall;

		private bool m_bDisposed;

		public SteamAPICall_t Handle => default(SteamAPICall_t);

		private event APIDispatchDelegate m_Func
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

		public static CallResult<T> Create(APIDispatchDelegate func = null)
		{
			return null;
		}

		public CallResult(APIDispatchDelegate func = null)
		{
		}

		~CallResult()
		{
		}

		public void Dispose()
		{
		}

		public void Set(SteamAPICall_t hAPICall, APIDispatchDelegate func = null)
		{
		}

		public bool IsActive()
		{
			return false;
		}

		public void Cancel()
		{
		}

		internal override Type GetCallbackType()
		{
			return null;
		}

		internal override void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall_)
		{
		}

		internal override void SetUnregistered()
		{
		}
	}
}
