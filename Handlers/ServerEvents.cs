using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace BroadcastingPlugin.Handlers
{
    public class ServerEvents
    {
        public void OnRoundstart()
        {
            Map.Broadcast(5, Plugin.Instance.Config.Roundstartmessage);
        }

        public void OnRoundEnd(RoundEndedEventArgs ev)
        {
            Map.Broadcast(5, Plugin.Instance.Config.RoundEndmessage);

            if (Plugin.Instance.Config.AllLightoff == true)
            {
                Map.TurnOffAllLights(20, false);
            }

            if (Plugin.Instance.Config.cassieStart == true)
            {
                Cassie.Message(Plugin.Instance.Config.cassieword, false, false);
            }
        }
    }
}