﻿using Xunit.Runners.Maui;

namespace MauiGroupedCollectionMemoryLeak.DeviceTests
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp() =>
        MauiApp
            .CreateBuilder()
            .ConfigureTests(new TestOptions()
            {
                Assemblies =
                {
                    typeof(MauiProgram).Assembly
                }
            })
            .UseVisualRunner()
            .Build();
    }
}
