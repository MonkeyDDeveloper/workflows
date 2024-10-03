namespace PortfolioBackend.Interfaces
{
    public interface ApiResponse<T>
    {
        string Message { get; set; }
        string Detail { get; set; }
        T Data { get; set; }
    }
}
