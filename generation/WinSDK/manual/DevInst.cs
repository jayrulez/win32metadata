﻿using System;
using System.Runtime.InteropServices;
using Windows.Win32.Interop;

namespace Windows.Win32.Devices.DeviceAndDriverInstallation
{
    public enum CONFIGRET : uint
    {
        CR_SUCCESS = (0x00000000),
        CR_DEFAULT = (0x00000001),
        CR_OUT_OF_MEMORY = (0x00000002),
        CR_INVALID_POINTER = (0x00000003),
        CR_INVALID_FLAG = (0x00000004),
        CR_INVALID_DEVNODE = (0x00000005),
        CR_INVALID_DEVINST = CR_INVALID_DEVNODE,
        CR_INVALID_RES_DES = (0x00000006),
        CR_INVALID_LOG_CONF = (0x00000007),
        CR_INVALID_ARBITRATOR = (0x00000008),
        CR_INVALID_NODELIST = (0x00000009),
        CR_DEVNODE_HAS_REQS = (0x0000000A),
        CR_DEVINST_HAS_REQS = CR_DEVNODE_HAS_REQS,
        CR_INVALID_RESOURCEID = (0x0000000B),
        CR_DLVXD_NOT_FOUND = (0x0000000C),
        CR_NO_SUCH_DEVNODE = (0x0000000D),
        CR_NO_SUCH_DEVINST = CR_NO_SUCH_DEVNODE,
        CR_NO_MORE_LOG_CONF = (0x0000000E),
        CR_NO_MORE_RES_DES = (0x0000000F),
        CR_ALREADY_SUCH_DEVNODE = (0x00000010),
        CR_ALREADY_SUCH_DEVINST = CR_ALREADY_SUCH_DEVNODE,
        CR_INVALID_RANGE_LIST = (0x00000011),
        CR_INVALID_RANGE = (0x00000012),
        CR_FAILURE = (0x00000013),
        CR_NO_SUCH_LOGICAL_DEV = (0x00000014),
        CR_CREATE_BLOCKED = (0x00000015),
        CR_NOT_SYSTEM_VM = (0x00000016),
        CR_REMOVE_VETOED = (0x00000017),
        CR_APM_VETOED = (0x00000018),
        CR_INVALID_LOAD_TYPE = (0x00000019),
        CR_BUFFER_SMALL = (0x0000001A),
        CR_NO_ARBITRATOR = (0x0000001B),
        CR_NO_REGISTRY_HANDLE = (0x0000001C),
        CR_REGISTRY_ERROR = (0x0000001D),
        CR_INVALID_DEVICE_ID = (0x0000001E),
        CR_INVALID_DATA = (0x0000001F),
        CR_INVALID_API = (0x00000020),
        CR_DEVLOADER_NOT_READY = (0x00000021),
        CR_NEED_RESTART = (0x00000022),
        CR_NO_MORE_HW_PROFILES = (0x00000023),
        CR_DEVICE_NOT_THERE = (0x00000024),
        CR_NO_SUCH_VALUE = (0x00000025),
        CR_WRONG_TYPE = (0x00000026),
        CR_INVALID_PRIORITY = (0x00000027),
        CR_NOT_DISABLEABLE = (0x00000028),
        CR_FREE_RESOURCES = (0x00000029),
        CR_QUERY_VETOED = (0x0000002A),
        CR_CANT_SHARE_IRQ = (0x0000002B),
        CR_NO_DEPENDENT = (0x0000002C),
        CR_SAME_RESOURCES = (0x0000002D),
        CR_NO_SUCH_REGISTRY_KEY = (0x0000002E),
        CR_INVALID_MACHINENAME = (0x0000002F),
        CR_REMOTE_COMM_FAILURE = (0x00000030),
        CR_MACHINE_UNAVAILABLE = (0x00000031),
        CR_NO_CM_SERVICES = (0x00000032),
        CR_ACCESS_DENIED = (0x00000033),
        CR_CALL_NOT_IMPLEMENTED = (0x00000034),
        CR_INVALID_PROPERTY = (0x00000035),
        CR_DEVICE_INTERFACE_ACTIVE = (0x00000036),
        CR_NO_SUCH_DEVICE_INTERFACE = (0x00000037),
        CR_INVALID_REFERENCE_STRING = (0x00000038),
        CR_INVALID_CONFLICT_LIST = (0x00000039),
        CR_INVALID_INDEX = (0x0000003A),
        CR_INVALID_STRUCTURE_SIZE = (0x0000003B),
        NUM_CR_RESULTS = (0x0000003C)
    }
    
    public static unsafe partial class Apis 
    {
        [DllImport("newdev.dll", EntryPoint = "DiInstallDevice", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        [SupportedOSPlatform("windows6.0.6000")]
        public static extern int DiInstallDeviceA([NativeTypeName("HWND")] [CppAttributeList("Name=SAL_name; p1=\"_In_opt_\"; p2=\"\"; p3=\"2\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_null; p1=__maybe^Name=SAL_pre^Name=SAL_valid^Name=SAL_name; p1=\"_Deref_pre_readonly_\"; p2=\"\"; p3=\"1.1\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_deref^Name=SAL_notref^Name=SAL_access; p1=0x1^Name=SAL_end^Name=SAL_end")] IntPtr hwndParent, [NativeTypeName("HDEVINFO")] [CppAttributeList("Name=SAL_name; p1=\"_In_\"; p2=\"\"; p3=\"2\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_null; p1=__no^Name=SAL_pre^Name=SAL_valid^Name=SAL_pre^Name=SAL_notref^Name=SAL_deref^Name=SAL_notref^Name=SAL_access; p1=0x1^Name=SAL_end")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] [CppAttributeList("Name=SAL_name; p1=\"_In_\"; p2=\"\"; p3=\"2\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_null; p1=__no^Name=SAL_pre^Name=SAL_valid^Name=SAL_pre^Name=SAL_notref^Name=SAL_deref^Name=SAL_notref^Name=SAL_access; p1=0x1^Name=SAL_end")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA")] [CppAttributeList("Name=SAL_name; p1=\"_In_opt_\"; p2=\"\"; p3=\"2\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_null; p1=__maybe^Name=SAL_pre^Name=SAL_valid^Name=SAL_name; p1=\"_Deref_pre_readonly_\"; p2=\"\"; p3=\"1.1\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_deref^Name=SAL_notref^Name=SAL_access; p1=0x1^Name=SAL_end^Name=SAL_end")] SP_DRVINFO_DATA_V2_A* DriverInfoData, [NativeTypeName("DWORD")] [CppAttributeList("Name=SAL_name; p1=\"_In_\"; p2=\"\"; p3=\"2\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_null; p1=__no^Name=SAL_pre^Name=SAL_valid^Name=SAL_pre^Name=SAL_notref^Name=SAL_deref^Name=SAL_notref^Name=SAL_access; p1=0x1^Name=SAL_end")] uint Flags, [NativeTypeName("PBOOL")] [CppAttributeList("Name=SAL_name; p1=\"_Out_opt_\"; p2=\"\"; p3=\"2\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_null; p1=__maybe^Name=SAL_pre^Name=SAL_notref^Name=SAL_writableTo; p1=elementCount(1)^Name=SAL_post^Name=SAL_valid^Name=SAL_end")] BOOL* NeedReboot);
        
        [DllImport("newdev.dll", EntryPoint = "DiInstallDevice", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        [SupportedOSPlatform("windows6.0.6000")]
        public static extern int DiInstallDeviceW([NativeTypeName("HWND")] [CppAttributeList("Name=SAL_name; p1=\"_In_opt_\"; p2=\"\"; p3=\"2\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_null; p1=__maybe^Name=SAL_pre^Name=SAL_valid^Name=SAL_name; p1=\"_Deref_pre_readonly_\"; p2=\"\"; p3=\"1.1\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_deref^Name=SAL_notref^Name=SAL_access; p1=0x1^Name=SAL_end^Name=SAL_end")] IntPtr hwndParent, [NativeTypeName("HDEVINFO")] [CppAttributeList("Name=SAL_name; p1=\"_In_\"; p2=\"\"; p3=\"2\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_null; p1=__no^Name=SAL_pre^Name=SAL_valid^Name=SAL_pre^Name=SAL_notref^Name=SAL_deref^Name=SAL_notref^Name=SAL_access; p1=0x1^Name=SAL_end")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] [CppAttributeList("Name=SAL_name; p1=\"_In_\"; p2=\"\"; p3=\"2\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_null; p1=__no^Name=SAL_pre^Name=SAL_valid^Name=SAL_pre^Name=SAL_notref^Name=SAL_deref^Name=SAL_notref^Name=SAL_access; p1=0x1^Name=SAL_end")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA")] [CppAttributeList("Name=SAL_name; p1=\"_In_opt_\"; p2=\"\"; p3=\"2\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_null; p1=__maybe^Name=SAL_pre^Name=SAL_valid^Name=SAL_name; p1=\"_Deref_pre_readonly_\"; p2=\"\"; p3=\"1.1\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_deref^Name=SAL_notref^Name=SAL_access; p1=0x1^Name=SAL_end^Name=SAL_end")] SP_DRVINFO_DATA_V2_W* DriverInfoData, [NativeTypeName("DWORD")] [CppAttributeList("Name=SAL_name; p1=\"_In_\"; p2=\"\"; p3=\"2\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_null; p1=__no^Name=SAL_pre^Name=SAL_valid^Name=SAL_pre^Name=SAL_notref^Name=SAL_deref^Name=SAL_notref^Name=SAL_access; p1=0x1^Name=SAL_end")] uint Flags, [NativeTypeName("PBOOL")] [CppAttributeList("Name=SAL_name; p1=\"_Out_opt_\"; p2=\"\"; p3=\"2\"^Name=SAL_begin^Name=SAL_pre^Name=SAL_notref^Name=SAL_null; p1=__maybe^Name=SAL_pre^Name=SAL_notref^Name=SAL_writableTo; p1=elementCount(1)^Name=SAL_post^Name=SAL_valid^Name=SAL_end")] BOOL* NeedReboot);
    }
}
