using Assets.Scripts.Unity.UI_New.Main;
namespace NKHook6.Api.Events._MainMenu
{
    public partial class MainMenuEvents
    {
        public class LoadedEvent : EventBase
        {
            public MainMenu menu;
            public LoadedEvent(MainMenu menu) : base("MainMenuLoadedEvent")
            {
                this.menu = menu;
            }
        }
    }
}
