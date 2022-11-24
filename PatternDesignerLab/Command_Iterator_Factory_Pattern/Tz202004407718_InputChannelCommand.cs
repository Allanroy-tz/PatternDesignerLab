
namespace Command_Iterator_Factory_Pattern
{
    public class Tz202004407718_InputChannelCommand : Tz202004407718_ICommand
    {
        private Tz202004407718_ITVIterator tvInterator;

        public void SetIterator(Tz202004407718_ITVIterator tvInterator) { this.tvInterator = tvInterator; }
        public void Execute()
        {
          
        }

        public void Set(object ob)
        {
            throw new System.NotImplementedException();
        }
    }
}