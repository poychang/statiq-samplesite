using Statiq.Markdown;

namespace Statiq.SampleSite;

public class Program
{
    public static async Task<int> Main(string[] args) =>
        await Bootstrapper
            .Factory
            .CreateWeb(args)
            .AddSetting(MarkdownKeys.MarkdownExtensions, new List<string> { "Bootstrap", "Prism" })
            .RunAsync();
}
