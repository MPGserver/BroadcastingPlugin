using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;
using MapEvents = Exiled.Events.Handlers.Map;
using Warhead = Exiled.Events.Handlers.Warhead;
using Exiled.API.Features;
using Exiled.API.Enums;
using System;

namespace BroadcastingPlugin
{
    public class Plugin : Plugin<Config>
    {
        private static readonly Lazy<Plugin> LazyInstance = new Lazy<Plugin>(() => new Plugin());
        public static Plugin Instance => LazyInstance.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Low;
        
        private Handlers.PlayerEvents player;
        private Handlers.ServerEvents server;
        private Handlers.WarheadEvents warhead;
        
        private Plugin()
        {
        }

        public override void OnEnabled()
        {
            base.OnEnabled();
            RegisterEvents();
            Log.Info($"BroadcastingPlugin On");
            Log.Info($"made by UN10#7291");
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            UnregisterEvents();
            Log.Info($"BroadcastingPlugin Off");
        }

        public void RegisterEvents()
        {
            player = new Handlers.PlayerEvents();
            server = new Handlers.ServerEvents();
            warhead = new Handlers.WarheadEvents();
            
            Player.Joined += player.OnJoin;
            Player.Left += player.OnLeft;
            Player.Died += player.OnScpcontain;
            MapEvents.AnnouncingNtfEntrance += player.OnMtfAnnounc;
            MapEvents.GeneratorActivated += player.OnGenOn;
            MapEvents.AnnouncingDecontamination += player.OnAnnouncingDecont;
            MapEvents.Decontaminating += player.OnDeont;
            Server.RoundStarted += server.OnRoundstart;
            Server.RoundEnded += server.OnRoundEnd;
            Warhead.Starting += warhead.OnAlphaStart;
            Warhead.Stopping += warhead.OnAlphaCancel;
        }

        public void UnregisterEvents()
        {
            Player.Joined -= player.OnJoin;
            Player.Left -= player.OnLeft;
            Player.Died -= player.OnScpcontain;
            MapEvents.AnnouncingNtfEntrance -= player.OnMtfAnnounc;
            MapEvents.GeneratorActivated -= player.OnGenOn;
            MapEvents.AnnouncingDecontamination -= player.OnAnnouncingDecont;
            MapEvents.Decontaminating -= player.OnDeont;
            Server.RoundStarted -= server.OnRoundstart;
            Server.RoundEnded -= server.OnRoundEnd;
            Warhead.Starting -= warhead.OnAlphaStart;
            Warhead.Stopping -= warhead.OnAlphaCancel;
            
            player = null;
            server = null;
            warhead = null;
        }
    }
}