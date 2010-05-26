/**
 * This code is free software; you can redistribute it and/or modify it under
 * the terms of the new BSD License.
 *
 * Copyright (c) 2010, Andrius Bentkus
 */

using System;
using System.Collections.Generic;

namespace SteamCondenser
{
	public static class Helper
	{
		public static string GetString(this byte[] value)
		{
			return System.Text.Encoding.ASCII.GetString(value);
		}
		
		public static byte[] GetBytes(this string value)
		{
			return System.Text.Encoding.ASCII.GetBytes(value);
		}
		
		public static byte[] GetBytes(this uint value)
		{
			return System.BitConverter.GetBytes(value);
		}
		
		public static byte[] GetBytes(this int value)
		{
			return System.BitConverter.GetBytes(value);
		}
		
		public static uint ReverseBytes(this uint value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if(BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			return BitConverter.ToUInt32(bytes, 0);
		}
		public static int ReverseBytes(this int value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if(BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			return BitConverter.ToInt32(bytes, 0);
		}
		public static ushort ReverseBytes(this ushort value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if(BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			return BitConverter.ToUInt16(bytes, 0);
		}
	}
}
