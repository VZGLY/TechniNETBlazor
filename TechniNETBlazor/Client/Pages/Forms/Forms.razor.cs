using Microsoft.Extensions.Options;
using System.Threading.Channels;
using shared = TechniNETBlazor.Shared;

namespace TechniNETBlazor.Client.Pages.Forms
{
    public partial class Forms
    {

        public shared.User monUser { get; set; } = new shared.User();


        public void Validate()
        {
            Console.WriteLine(monUser.Email);
        }

        public void Invalidate()
        {
            Console.WriteLine("Fail");
        }


    }
}
