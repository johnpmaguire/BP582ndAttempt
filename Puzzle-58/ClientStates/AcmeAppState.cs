using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Puzzle_58.Components
{
    public partial class AcmeAppState : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        public string AcmeAppStateText = "This is the home page for ACME.";
        public string AcmeAppConfigPageStateText = "This is the Config page for ACME.";

       
    }
}
