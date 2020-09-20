﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_TimeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("Time");
		L.RegVar("time", new LuaCSFunction(get_time), null);
		L.RegVar("timeSinceLevelLoad", new LuaCSFunction(get_timeSinceLevelLoad), null);
		L.RegVar("deltaTime", new LuaCSFunction(get_deltaTime), null);
		L.RegVar("fixedTime", new LuaCSFunction(get_fixedTime), null);
		L.RegVar("unscaledTime", new LuaCSFunction(get_unscaledTime), null);
		L.RegVar("fixedUnscaledTime", new LuaCSFunction(get_fixedUnscaledTime), null);
		L.RegVar("unscaledDeltaTime", new LuaCSFunction(get_unscaledDeltaTime), null);
		L.RegVar("fixedUnscaledDeltaTime", new LuaCSFunction(get_fixedUnscaledDeltaTime), null);
		L.RegVar("fixedDeltaTime", new LuaCSFunction(get_fixedDeltaTime), new LuaCSFunction(set_fixedDeltaTime));
		L.RegVar("maximumDeltaTime", new LuaCSFunction(get_maximumDeltaTime), new LuaCSFunction(set_maximumDeltaTime));
		L.RegVar("smoothDeltaTime", new LuaCSFunction(get_smoothDeltaTime), null);
		L.RegVar("maximumParticleDeltaTime", new LuaCSFunction(get_maximumParticleDeltaTime), new LuaCSFunction(set_maximumParticleDeltaTime));
		L.RegVar("timeScale", new LuaCSFunction(get_timeScale), new LuaCSFunction(set_timeScale));
		L.RegVar("frameCount", new LuaCSFunction(get_frameCount), null);
		L.RegVar("renderedFrameCount", new LuaCSFunction(get_renderedFrameCount), null);
		L.RegVar("realtimeSinceStartup", new LuaCSFunction(get_realtimeSinceStartup), null);
		L.RegVar("captureDeltaTime", new LuaCSFunction(get_captureDeltaTime), new LuaCSFunction(set_captureDeltaTime));
		L.RegVar("captureFramerate", new LuaCSFunction(get_captureFramerate), new LuaCSFunction(set_captureFramerate));
		L.RegVar("inFixedTimeStep", new LuaCSFunction(get_inFixedTimeStep), null);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_time(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.time);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timeSinceLevelLoad(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.timeSinceLevelLoad);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_deltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.deltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fixedTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.fixedTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_unscaledTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.unscaledTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fixedUnscaledTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.fixedUnscaledTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_unscaledDeltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.unscaledDeltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fixedUnscaledDeltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.fixedUnscaledDeltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fixedDeltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.fixedDeltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maximumDeltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.maximumDeltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_smoothDeltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.smoothDeltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maximumParticleDeltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.maximumParticleDeltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timeScale(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.timeScale);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_frameCount(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Time.frameCount);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderedFrameCount(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Time.renderedFrameCount);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_realtimeSinceStartup(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.realtimeSinceStartup);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_captureDeltaTime(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Time.captureDeltaTime);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_captureFramerate(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Time.captureFramerate);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inFixedTimeStep(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Time.inFixedTimeStep);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fixedDeltaTime(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.fixedDeltaTime = arg0;
			UnityEngine.Time.fixedDeltaTime = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maximumDeltaTime(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.maximumDeltaTime = arg0;
			UnityEngine.Time.maximumDeltaTime = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maximumParticleDeltaTime(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.maximumParticleDeltaTime = arg0;
			UnityEngine.Time.maximumParticleDeltaTime = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_timeScale(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.timeScale = arg0;
			UnityEngine.Time.timeScale = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_captureDeltaTime(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Time.captureDeltaTime = arg0;
			UnityEngine.Time.captureDeltaTime = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_captureFramerate(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.Time.captureFramerate = arg0;
			UnityEngine.Time.captureFramerate = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

