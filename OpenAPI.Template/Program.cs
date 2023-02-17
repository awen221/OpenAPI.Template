new StartUp().Main(args);
/// <summary>
/// StartUp
/// </summary>
class StartUp : OpenAPI.StartUp
{
    /// <summary>
    /// 
    /// </summary>
    protected override string Title => "OpenAPI";
    /// <summary>
    /// 
    /// </summary>
    protected override Version Version => new Version("1.0.0.0");
    /// <summary>
    /// 
    /// </summary>
    protected override string Description => "OpenAPI Description";
}