namespace Messages
{
    public interface IMessages
    {
        void PlateauMessage();
        void PlateauMessageCommand();
        void FinalMessage(int x, int y, string direction);
    }
}