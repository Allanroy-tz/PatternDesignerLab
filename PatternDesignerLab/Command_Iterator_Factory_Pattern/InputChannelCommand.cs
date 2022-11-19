
namespace Command_Iterator_Factory_Pattern
{
    public class InputChannelCommand : ICommand
    {
        private ITVIterator tvInterator;

        public void SetIterator(ITVIterator tvInterator) { this.tvInterator = tvInterator; }
        public void Execute()
        {
          
        }

        public void Set(object ob)
        {
            throw new System.NotImplementedException();
        }
    }
}