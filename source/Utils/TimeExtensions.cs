﻿using System;

namespace Peer2Net.Utils
{
    static class TimeExtensions
    {
        internal static TimeSpan Seconds(this int seconds)
        {
            return TimeSpan.FromSeconds(seconds);
        }

        internal static TimeSpan Milliseconds(this int milliseconds)
        {
            return TimeSpan.FromMilliseconds(milliseconds);
        }
    }
}
