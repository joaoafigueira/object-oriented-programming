namespace OOP
{
    public interface IRepository
    {
        void Add();

        //An interface is a contract that a class implements.
    }

    public class Repository : IRepository
    {
        public void Add()
        {
            // Add item
        }

        // Here is an example of a class implementing the contract (interface)
    }

    public class Implementation
    {
        public void Process()
        {
            var repository = new Repository();
            repository.Add();
        }

        // The code here is too coupled because if the Repository class changes,
        // it is going to need to adapt to the changes.
    }

    public class UseAbstraction
    {
        private readonly IRepository _repository;

        public UseAbstraction(IRepository repository)
        {
            _repository = repository;
        }

        public void Process()
        {
            _repository.Add();
        }

        // Here the code is working to the Interface becoming less coupled to changes.
    }
}
