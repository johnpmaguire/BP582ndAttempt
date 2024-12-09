using Microsoft.AspNetCore.Components;

namespace Puzzle_58.Components
{
    public partial class ContosoAppState : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        public string ContosoAppStateText = "This is the home page for Contoso.";
        public string ContosoAppConfigPageStateText = "This is the Config page for Contoso.";

        // Add properties here that you want to share across Contoso client pages
    }
}
