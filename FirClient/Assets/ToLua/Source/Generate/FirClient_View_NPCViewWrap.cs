﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FirClient_View_NPCViewWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FirClient.View.NPCView), typeof(BaseBehaviour));
		L.RegFunction("OnAwake", new LuaCSFunction(OnAwake));
		L.RegFunction("Initialize", new LuaCSFunction(Initialize));
		L.RegFunction("OnUpdate", new LuaCSFunction(OnUpdate));
		L.RegFunction("OnDispose", new LuaCSFunction(OnDispose));
		L.RegFunction("New", new LuaCSFunction(_CreateFirClient_View_NPCView));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("gameObject", new LuaCSFunction(get_gameObject), new LuaCSFunction(set_gameObject));
		L.RegVar("viewObject", new LuaCSFunction(get_viewObject), new LuaCSFunction(set_viewObject));
		L.RegVar("NpcData", new LuaCSFunction(get_NpcData), new LuaCSFunction(set_NpcData));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFirClient_View_NPCView(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FirClient.View.NPCView obj = new FirClient.View.NPCView();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FirClient.View.NPCView.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnAwake(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FirClient.View.NPCView obj = (FirClient.View.NPCView)ToLua.CheckObject<FirClient.View.NPCView>(L, 1);
			obj.OnAwake();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Initialize(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				FirClient.View.NPCView obj = (FirClient.View.NPCView)ToLua.CheckObject<FirClient.View.NPCView>(L, 1);
				FirClient.Data.NPCData arg0 = (FirClient.Data.NPCData)ToLua.CheckObject<FirClient.Data.NPCData>(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				obj.Initialize(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				FirClient.View.NPCView obj = (FirClient.View.NPCView)ToLua.CheckObject<FirClient.View.NPCView>(L, 1);
				FirClient.Data.NPCData arg0 = (FirClient.Data.NPCData)ToLua.CheckObject<FirClient.Data.NPCData>(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				System.Action arg2 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 4);
				obj.Initialize(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FirClient.View.NPCView.Initialize");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FirClient.View.NPCView obj = (FirClient.View.NPCView)ToLua.CheckObject<FirClient.View.NPCView>(L, 1);
			obj.OnUpdate();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FirClient.View.NPCView obj = (FirClient.View.NPCView)ToLua.CheckObject<FirClient.View.NPCView>(L, 1);
			obj.OnDispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gameObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirClient.View.NPCView obj = (FirClient.View.NPCView)o;
			UnityEngine.GameObject ret = obj.gameObject;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index gameObject on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_viewObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirClient.View.NPCView obj = (FirClient.View.NPCView)o;
			FirClient.View.ViewObject ret = obj.viewObject;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index viewObject on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_NpcData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirClient.View.NPCView obj = (FirClient.View.NPCView)o;
			FirClient.Data.NPCData ret = obj.NpcData;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index NpcData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_gameObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirClient.View.NPCView obj = (FirClient.View.NPCView)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject<UnityEngine.GameObject>(L, 2);
			obj.gameObject = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index gameObject on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_viewObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirClient.View.NPCView obj = (FirClient.View.NPCView)o;
			FirClient.View.ViewObject arg0 = (FirClient.View.ViewObject)ToLua.CheckObject<FirClient.View.ViewObject>(L, 2);
			obj.viewObject = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index viewObject on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_NpcData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirClient.View.NPCView obj = (FirClient.View.NPCView)o;
			FirClient.Data.NPCData arg0 = (FirClient.Data.NPCData)ToLua.CheckObject<FirClient.Data.NPCData>(L, 2);
			obj.NpcData = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index NpcData on a nil value");
		}
	}
}

