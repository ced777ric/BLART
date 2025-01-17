#pragma warning disable CS8618
namespace BLART;

public class Config
{		
    public string BotPrefix { get; set; }
    public string BotToken { get; set; }
    public ulong DiscStaffId { get; set; }
    public int SpamLimit { get; set; }
    public int SpamTimeout { get; set; }
    public ulong ChannelRentId { get; set; }
    public ulong ChannelRentCatId { get; set; }
    public ulong LogsId { get; set; }
    public bool Debug { get; set; }
    public ulong RedRoleId { get; set; }
    public ulong BugReportId { get; set; }
    public int TriggerLengthLimit { get; set; }

    public static readonly Config Default = new Config
    {
        BotToken = string.Empty,
        BotPrefix = "~",
        DiscStaffId = 0,
        SpamLimit = 10,
        SpamTimeout = 5,
        ChannelRentId = 0,
        ChannelRentCatId = 0,
        LogsId = 0,
        Debug = false,
        RedRoleId = 0,
        BugReportId = 0,
        TriggerLengthLimit = 200,
    };
}