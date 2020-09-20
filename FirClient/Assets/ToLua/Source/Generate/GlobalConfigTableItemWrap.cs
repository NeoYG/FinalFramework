﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GlobalConfigTableItemWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(GlobalConfigTableItem), typeof(System.Object));
		L.RegFunction("New", new LuaCSFunction(_CreateGlobalConfigTableItem));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("id", new LuaCSFunction(get_id), new LuaCSFunction(set_id));
		L.RegVar("value", new LuaCSFunction(get_value), new LuaCSFunction(set_value));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGlobalConfigTableItem(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				GlobalConfigTableItem obj = new GlobalConfigTableItem();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: GlobalConfigTableItem.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GlobalConfigTableItem obj = (GlobalConfigTableItem)o;
			string ret = obj.id;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index id on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GlobalConfigTableItem obj = (GlobalConfigTableItem)o;
			string ret = obj.value;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index value on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GlobalConfigTableItem obj = (GlobalConfigTableItem)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.id = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index id on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GlobalConfigTableItem obj = (GlobalConfigTableItem)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.value = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index value on a nil value");
		}
	}
}

