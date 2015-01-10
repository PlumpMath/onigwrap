﻿using System;
using System.Runtime.InteropServices;

namespace OnigRegex
{
    internal unsafe class OnigInterop
    {
        [DllImport("onigwrap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr onigwrap_create(string pattern, int len);

        [DllImport("onigwrap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void onigwrap_region_free(IntPtr region);

        [DllImport("onigwrap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void onigwrap_free(IntPtr regex);

        [DllImport("onigwrap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int onigwrap_index_in(IntPtr regex, string text, int offset, int length);

        [DllImport("onigwrap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr onigwrap_search(IntPtr regex, string text, int offset, int length);

        [DllImport("onigwrap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int onigwrap_pos(IntPtr region, int nth);

        [DllImport("onigwrap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int onigwrap_len(IntPtr region, int nth);
    }
}
