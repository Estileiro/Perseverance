using Perseverance;

namespace Robot
{
    public class DirectionManager
    {
        private readonly List<IDirection> _direction = new List<IDirection>();
        public bool HasPendingDirection =>
            _direction.Any(x =>
                x.Status == ExecutionStatus.Unprocessed ||
                x.Status == ExecutionStatus.ExecuteSucceeded ||
                x.Status == ExecutionStatus.ExecuteFailed);
        public void AddDirection(IDirection direction)
        {
            _direction.Add(direction);
        }
        public void ProcessDirection()
        {
            foreach (IDirection direction in _direction.Where(x =>
                        x.Status == ExecutionStatus.Unprocessed ||
                        x.Status == ExecutionStatus.ExecuteSucceeded ||
                        x.Status == ExecutionStatus.ExecuteFailed))
            {
                try
                {
                    direction.Execute();
                }
                catch (Exception e)
                {

                    direction.Status = ExecutionStatus.ExecuteFailed;
                }
            }
        }
    }
}
