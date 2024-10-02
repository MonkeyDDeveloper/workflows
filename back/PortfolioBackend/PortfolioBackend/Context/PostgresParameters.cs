namespace PortfolioBackend.Context
{
    public interface PostgresParameters
    {
        public string DbUser { get; set; }
        public string DbPassword { get; set; }

        public string DbHost { get; set; }

        public string DbPort { get; set; }
        public string DbName { get; set; }

    }
}
