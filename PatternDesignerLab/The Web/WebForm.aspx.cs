namespace The_Web
{
    public partial class WebForm : System.Web.UI.Page
    {
        public int count;
        protected void Page_Load(object sender, EventArgs e)
        {
            count=Singleton.Instance.Add();
        }
    }
}