namespace Perseverance;

    public interface IDirection
    {     
        ExecutionStatus Status { get; set; }
        void Execute();
    }

