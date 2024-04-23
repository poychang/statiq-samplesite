namespace Statiq.SampleSite;

public class Program
{
    public static async Task<int> Main(string[] args) =>
        await Bootstrapper
            .Factory
            .CreateWeb(args)
            .AddSetting(Markdown.MarkdownKeys.MarkdownExtensions, new List<string> { "Bootstrap", "SyntaxHighlighting" })
            .RunAsync();
}
