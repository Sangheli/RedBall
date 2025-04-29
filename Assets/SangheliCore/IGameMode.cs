namespace SangheliCore
{
    public interface IGameMode
    {
        int WinCollectableValue { get; }
        void OnWin();
        void OnLose();
    }
}