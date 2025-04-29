namespace SangheliCore
{
    public interface IGameMode
    {
        int WinCollectableValue { get; }
        void Init();
        void Start();
        void OnWin();
        void OnLose();
    }
}