namespace signalrserver.Hub_connection
{
    public interface IMessageHub
    {
        Task SendBalanceUpdate(string message, string user);
        Task AddToGroup(string groupName);
        Task RemoveFromGroup(string groupName);
    }
}
