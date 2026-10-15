using Shoko.Abstractions.Plugin;
using Shoko.Abstractions.Utilities;
using Shoko.Plugin.WebhookDump.Configurations;

namespace Shoko.Plugin.WebhookDump;

public class Plugin : IPlugin<PluginConfiguration>
{
  public Guid ID => UuidUtility.GetV5(GetType().FullName!);
  public string Name => "WebhookDump";

  public string Description =>
    "Automatically AVDumps unrecognised files, optionally sending a notification to Discord via a webhook.";
}
