using System.Diagnostics;

namespace MigrationService;

public class Worker(
    IHostApplicationLifetime hostApplicationLifetime,
    ILogger<Worker> logger
) : BackgroundService
{
    private readonly ILogger<Worker> _logger = logger;
    public const string ActivitySourceName = "Migrations";
    private static readonly ActivitySource _activitySource = new(ActivitySourceName);

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        using var activity = _activitySource.StartActivity(
            "Migrating database",
            ActivityKind.Client
        );
        try
        {
            await Task.Delay(2000, cancellationToken);
        }
        catch (Exception ex)
        {
            activity?.AddException(ex);
            throw;
        }
        hostApplicationLifetime.StopApplication();
    }
}
