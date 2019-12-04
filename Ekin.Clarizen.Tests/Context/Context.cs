﻿using System;
using System.Globalization;
using System.Threading;
using Ekin.Clarizen;
using Ekin.Clarizen.Tests;

namespace Clarizen.Tests.Context
{
    public class BaseContext : IDisposable
    {
        public BaseContext()
        {
            TimeProvider.ResetToDefault();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
        }

        public API Api { get; set; }
        public string ProjectId { get; internal set; }
        public dynamic SUT { get; internal set; }
        public string UserId { get; set; }

        public void Dispose()
        {
            TimeProvider.ResetToDefault();
            Api?.Logout();
        }
    }
}