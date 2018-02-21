namespace ILogic
{
    public interface ILinker
    {
        bool chooseNewSource();
        string getSourceFileName();
        void playSource();
        void stopSource();
        void scramble();
        void playResult();
        void stopResult();
        void saveResult();
    }
}
