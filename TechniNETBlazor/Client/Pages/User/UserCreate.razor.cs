namespace TechniNETBlazor.Client.Pages.User
{
    public partial class UserCreate
    {
        public int MaProp { get; set; } = 12;

        public string Value { get; set; }

        public void ReceiveHello(string value)
        {
            this.Value = value;
        }
    }
}
