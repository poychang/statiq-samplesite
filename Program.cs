﻿using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Markdown;
using Statiq.Web;

namespace Statiq.SampleSite;

public class Program
{
    public static async Task<int> Main(string[] args) =>
        await Bootstrapper
            .Factory
            .CreateWeb(args)
            .RunAsync();
}
