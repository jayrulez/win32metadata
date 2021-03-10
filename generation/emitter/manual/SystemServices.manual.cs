﻿using System;
using System.Runtime.InteropServices;
using Windows.Win32.Interop;

namespace Windows.Win32.SystemServices
{
    public static unsafe partial class Apis
    {
        public const int TRUE = 1;

        public const int FALSE = 0;

        [NativeTypeName("HANDLE")]
        public const int INVALID_HANDLE_VALUE = -1;

        public const uint _MM_HINT_T0  = 1;
        public const uint _MM_HINT_T1  = 2;
        public const uint _MM_HINT_T2  = 3;
        public const uint _MM_HINT_NTA = 0;
    }

    [Flags]
    public enum CONSOLE_MODE : uint
    {
        ENABLE_ECHO_INPUT = 0x0004,
        ENABLE_INSERT_MODE = 0x0020,
        ENABLE_LINE_INPUT = 0x0002,
        ENABLE_MOUSE_INPUT = 0x0010,
        ENABLE_PROCESSED_INPUT = 0x0001,
        ENABLE_QUICK_EDIT_MODE = 0x0040,
        ENABLE_WINDOW_INPUT = 0x0008,
        ENABLE_VIRTUAL_TERMINAL_INPUT = 0x0200,
        ENABLE_PROCESSED_OUTPUT = 0x0001,
        ENABLE_WRAP_AT_EOL_OUTPUT = 0x0002,
        ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004,
        DISABLE_NEWLINE_AUTO_RETURN = 0x0008,
        ENABLE_LVB_GRID_WORLDWIDE = 0x0010
    }

    [Flags]
    public enum PAGE_TYPE : uint
    {
        PAGE_NOACCESS = 0x1,
        PAGE_READONLY = 0x2,
        PAGE_READWRITE = 0x4,
        PAGE_WRITECOPY = 0x8,
        PAGE_EXECUTE = 0x10,
        PAGE_EXECUTE_READ = 0x20,
        PAGE_EXECUTE_READWRITE = 0x40,
        PAGE_EXECUTE_WRITECOPY = 0x80,
        PAGE_GUARD = 0x100,
        PAGE_NOCACHE = 0x200,
        PAGE_WRITECOMBINE = 0x400,
        PAGE_TARGETS_INVALID = 0x40000000,
        PAGE_TARGETS_NO_UPDATE = 0x40000000
    }

    [Flags]
    public enum PROCESS_ACCESS_RIGHTS : uint
    {
        PROCESS_TERMINATE = (0x0001),
        PROCESS_CREATE_THREAD = (0x0002),
        PROCESS_SET_SESSIONID = (0x0004),
        PROCESS_VM_OPERATION = (0x0008),
        PROCESS_VM_READ = (0x0010),
        PROCESS_VM_WRITE = (0x0020),
        PROCESS_DUP_HANDLE = (0x0040),
        PROCESS_CREATE_PROCESS = (0x0080),
        PROCESS_SET_QUOTA = (0x0100),
        PROCESS_SET_INFORMATION = (0x0200),
        PROCESS_QUERY_INFORMATION = (0x0400),
        PROCESS_SUSPEND_RESUME = (0x0800),
        PROCESS_QUERY_LIMITED_INFORMATION = (0x1000),
        PROCESS_SET_LIMITED_INFORMATION = (0x2000),
        PROCESS_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0xFFFF),
        DELETE = (0x00010000),
        READ_CONTROL = (0x00020000),
        WRITE_DAC = (0x00040000),
        WRITE_OWNER = (0x00080000),
        SYNCHRONIZE = (0x00100000),
        STANDARD_RIGHTS_REQUIRED = (0x000F0000)
    }

    [Flags]
    public enum JOB_OBJECT_LIMIT : uint
    {
        JOB_OBJECT_LIMIT_WORKINGSET = 0x00000001,
        JOB_OBJECT_LIMIT_PROCESS_TIME = 0x00000002,
        JOB_OBJECT_LIMIT_JOB_TIME = 0x00000004,
        JOB_OBJECT_LIMIT_ACTIVE_PROCESS = 0x00000008,
        JOB_OBJECT_LIMIT_AFFINITY = 0x00000010,
        JOB_OBJECT_LIMIT_PRIORITY_CLASS = 0x00000020,
        JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME = 0x00000040,
        JOB_OBJECT_LIMIT_SCHEDULING_CLASS = 0x00000080,
        JOB_OBJECT_LIMIT_PROCESS_MEMORY = 0x00000100,
        JOB_OBJECT_LIMIT_JOB_MEMORY = 0x00000200,
        JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH = JOB_OBJECT_LIMIT_JOB_MEMORY,
        JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION = 0x00000400,
        JOB_OBJECT_LIMIT_BREAKAWAY_OK = 0x00000800,
        JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK = 0x00001000,
        JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE = 0x00002000,
        JOB_OBJECT_LIMIT_SUBSET_AFFINITY = 0x00004000,
        JOB_OBJECT_LIMIT_JOB_MEMORY_LOW = 0x00008000,
        JOB_OBJECT_LIMIT_JOB_READ_BYTES = 0x00010000,
        JOB_OBJECT_LIMIT_JOB_WRITE_BYTES = 0x00020000,
        JOB_OBJECT_LIMIT_RATE_CONTROL = 0x00040000,
        JOB_OBJECT_LIMIT_CPU_RATE_CONTROL = JOB_OBJECT_LIMIT_RATE_CONTROL,
        JOB_OBJECT_LIMIT_IO_RATE_CONTROL = 0x00080000,
        JOB_OBJECT_LIMIT_NET_RATE_CONTROL = 0x00100000,
        JOB_OBJECT_LIMIT_VALID_FLAGS = 0x0007ffff,
        JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS = 0x000000ff,
        JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS = 0x00007fff,
        JOB_OBJECT_NOTIFICATION_LIMIT_VALID_FLAGS = (JOB_OBJECT_LIMIT_JOB_READ_BYTES | JOB_OBJECT_LIMIT_JOB_WRITE_BYTES | JOB_OBJECT_LIMIT_JOB_TIME | JOB_OBJECT_LIMIT_JOB_MEMORY_LOW | JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH | JOB_OBJECT_LIMIT_CPU_RATE_CONTROL | JOB_OBJECT_LIMIT_IO_RATE_CONTROL | JOB_OBJECT_LIMIT_NET_RATE_CONTROL),
    }

    [Flags]
    public enum JOB_OBJECT_UILIMIT : uint
    {
        JOB_OBJECT_UILIMIT_NONE = 0x00000000,
        JOB_OBJECT_UILIMIT_HANDLES = 0x00000001,
        JOB_OBJECT_UILIMIT_READCLIPBOARD = 0x00000002,
        JOB_OBJECT_UILIMIT_WRITECLIPBOARD = 0x00000004,
        JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS = 0x00000008,
        JOB_OBJECT_UILIMIT_DISPLAYSETTINGS = 0x00000010,
        JOB_OBJECT_UILIMIT_GLOBALATOMS = 0x00000020,
        JOB_OBJECT_UILIMIT_DESKTOP = 0x00000040,
        JOB_OBJECT_UILIMIT_EXITWINDOWS = 0x00000080
    }

    [Flags]
    public enum JOB_OBJECT_SECURITY : uint
    {
        JOB_OBJECT_SECURITY_NO_ADMIN = 0x00000001,
        JOB_OBJECT_SECURITY_RESTRICTED_TOKEN = 0x00000002,
        JOB_OBJECT_SECURITY_ONLY_TOKEN = 0x00000004,
        JOB_OBJECT_SECURITY_FILTER_TOKENS = 0x00000008,
        JOB_OBJECT_SECURITY_VALID_FLAGS = 0x0000000f
    }

    public enum WAIT_RETURN_CAUSE : uint
    {
        WAIT_OBJECT_0 = 0x00000000,
        WAIT_ABANDONED = 0x00000080,
        WAIT_ABANDONED_0 = 0x00000080,
        WAIT_IO_COMPLETION = 0x000000C0,
        WAIT_TIMEOUT = 0x00000102,
        WAIT_FAILED = 0xFFFFFFFF
    }
}
