﻿using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace SharpPhysFS
{
  [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
  public delegate int InitDelegate();
  [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
  public delegate void DeinitDelegate();
  [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
  public delegate IntPtr MallocDelegate(ulong size);
  [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
  public delegate IntPtr ReallocDelegate(IntPtr ptr, ulong size);
  [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
  public delegate void FreeDelegate(IntPtr ptr);
  [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
  public delegate void StringCallback(IntPtr data, string str);
  [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
  public delegate void EnumFilesCallback(IntPtr data, string origdir, string fname);

  [StructLayout(LayoutKind.Sequential)]
  public struct ArchiveInfo
  {
    [MarshalAs(UnmanagedType.LPStr)]
    public string extension;

    [MarshalAs(UnmanagedType.LPStr)]
    public string description;

    [MarshalAs(UnmanagedType.LPStr)]
    public string author;

    [MarshalAs(UnmanagedType.LPStr)]
    public string url;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct Version
  {
    public byte major;
    public byte minor;
    public byte patch;
  }

  [StructLayout(LayoutKind.Sequential)]
  public struct Allocator
  {
    [MarshalAs(UnmanagedType.FunctionPtr)]
    public InitDelegate Init;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public DeinitDelegate Deinit;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public MallocDelegate Malloc;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public ReallocDelegate Realloc;

    [MarshalAs(UnmanagedType.FunctionPtr)]
    public FreeDelegate Free;
  }
  static class Interop
    {
    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void PHYSFS_getLinkedVersion(ref Version v);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_init(string argv0);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_deinit();

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_supportedArchiveTypes();

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void PHYSFS_freeList(IntPtr h);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_getLastError();

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_getDirSeparator();

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void PHYSFS_permitSymbolicLinks(int permit);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_getCdRomDirs();

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_getBaseDir();

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_getUserDir();

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_getWriteDir();

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_setWriteDir(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_addToSearchPath(string s, int i);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_removeFromSearchPath(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_getSearchPath();

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_setSaneConfig(string s1, string s2, string s3, int i1, int i2);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_mkdir(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_delete(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_getRealDir(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_enumerateFiles(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_exists(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_isDirectory(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_isSymbolicLink(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern long PHYSFS_getLastModTime(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_openWrite(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_openAppend(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_openRead(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_close(IntPtr ptr);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern long PHYSFS_read(IntPtr ptr1, IntPtr ptr2, uint i1, uint i2);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern long PHYSFS_write(IntPtr ptr1, IntPtr ptr2, uint i1, uint i2);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_eof(IntPtr ptr);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern long PHYSFS_tell(IntPtr ptr);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_seek(IntPtr ptr, ulong u);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern long PHYSFS_fileLength(IntPtr ptr);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_setBuffer(IntPtr ptr, ulong u);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_flush(IntPtr ptr);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_isInit();

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_symbolicLinksPermitted();

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_setAllocator(Allocator alloc);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern int PHYSFS_mount(string s1, string s2, int i);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr PHYSFS_getMountPoint(string s);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void PHYSFS_getCdRomDirsCallback(StringCallback c, IntPtr p);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void PHYSFS_getSearchPathCallback(StringCallback c, IntPtr p);

    [DllImport("libphysfs", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern void PHYSFS_enumerateFilesCallback(string s, EnumFilesCallback c, IntPtr p);
  }
}
