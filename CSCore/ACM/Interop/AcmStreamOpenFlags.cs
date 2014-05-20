﻿namespace CSCore.ACM
{
    [System.Flags]
    public enum AcmStreamOpenFlags
    {
        ACM_STREAM_OPENF_ASYNC = 0x00000002,
        ACM_STREAMOPENF_NONREALTIME = 0x00000004,
        ACM_STREAMOPENF_QUERY = 0x00000001,
        CALLBACK_EVENT = 0x00050000,
        CALLBACK_FUNCTION = 0x00030000,
        CALLBACK_WINDOW = 0x00010000
    }
}