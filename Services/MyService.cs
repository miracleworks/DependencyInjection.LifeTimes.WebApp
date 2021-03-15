namespace DI.LifeTimes.WebApp.Services
{
    public interface IMyService
    {
        public System.Guid getSingleton();
        public System.Guid getTransient();
        public System.Guid getScoped();
    }

    public class MyService : IMyService
    {
        private readonly ISingletonOperation _singletonOperation;
        private readonly ITransientOperation _transientOperation;
        private readonly IScopedOperation _scopedOperation;

        public MyService
         (
             ISingletonOperation singletonOperation,
             ITransientOperation transientOperation,
             IScopedOperation scopedOperation
         )
        {
            _singletonOperation = singletonOperation;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
        }

        public System.Guid getSingleton()
        {
            return _singletonOperation.Id;
        }

        public System.Guid getTransient()
        {
            return _transientOperation.Id;
        }

        public System.Guid getScoped()
        {
            return _scopedOperation.Id;
        }

    }
}
