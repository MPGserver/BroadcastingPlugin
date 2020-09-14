using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace BroadcastingPlugin.Handlers
{
    public class PlayerEvents
    {
        public void OnJoin(JoinedEventArgs ev)
        {
            if (Plugin.Instance.Config.joinuse == true)
            {
                Map.Broadcast(5, Plugin.Instance.Config.Joinmessage.Replace("{player.Nickname}", ev.Player.Nickname).Replace("{player}",ev.Player.UserId));
            }
        }

        public void OnLeft(LeftEventArgs ev)
        {
            if (Plugin.Instance.Config.leftuse == true)
            {
                Map.Broadcast(5, Plugin.Instance.Config.Leftmessage.Replace("{player.Nickname}", ev.Player.Nickname).Replace("{player}", ev.Player.UserId));
            }
        }
        
        public void OnScpcontain(DiedEventArgs ev)
        {
            var targetrole = ev.Target.ReferenceHub.characterClassManager._prevId;
            var killerrole = ev.Killer.ReferenceHub.characterClassManager._prevId;
            string targetname = CharacterClassManager._staticClasses.Get(targetrole).fullName;
            string rolename = CharacterClassManager._staticClasses.Get(killerrole).fullName;
            string unitname = ev.Killer.ReferenceHub.characterClassManager.CurUnitName;
            Log.Info($"SCP Contained successfully.");
            if (ev.Target.Role == RoleType.Scp049)
            {
                if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-049</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=green>Chaos Insurgency</color></size>");
                }
                else if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-049</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=orange>Class D personnel</color></size>");
                }
                else if (ev.Killer.Role == RoleType.FacilityGuard)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-049</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=gray>시설 경비</color></size>");
                }
                else if (ev.Killer.Role == RoleType.None)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-049</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCadet)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-049</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#00D8FF>MTF 사관생도({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCommander)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-049</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#050099>MTF 지휘관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfLieutenant)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-049</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 부사령관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfScientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-049</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 과학자({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-049</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=yellow>Scientist</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Spectator)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-049</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>관전자</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Tutorial)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-049</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=cyan>튜토리얼</color></size>");
                }
                else
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-049</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
            }
            if (ev.Target.Role == RoleType.Scp096)
            {
                if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-096</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=green>Chaos Insurgency</color></size>");
                }
                else if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-096</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=orange>Class D personnel</color></size>");
                }
                else if (ev.Killer.Role == RoleType.FacilityGuard)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-096</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=gray>시설 경비</color></size>");
                }
                else if (ev.Killer.Role == RoleType.None)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-096</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCadet)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-096</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#00D8FF>MTF 사관생도({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCommander)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-096</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#050099>MTF 지휘관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfLieutenant)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-096</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 부사령관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfScientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-096</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 과학자({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-096</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=yellow>Scientist</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Spectator)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-096</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>관전자</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Tutorial)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-096</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=cyan>튜토리얼</color></size>");
                }
                else
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-096</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
            }
            if (ev.Target.Role == RoleType.Scp106)
            {
                if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=green>Chaos Insurgency</color></size>");
                }
                else if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=orange>Class D personnel</color></size>");
                }
                else if (ev.Killer.Role == RoleType.FacilityGuard)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=gray>시설 경비</color></size>");
                }
                else if (ev.Killer.Role == RoleType.None)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCadet)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#00D8FF>MTF 사관생도({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCommander)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#050099>MTF 지휘관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfLieutenant)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 부사령관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfScientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 과학자({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=yellow>Scientist</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Spectator)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>관전자</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Tutorial)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=cyan>튜토리얼</color></size>");
                }
                else
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
            }
            if (ev.Target.Role == RoleType.Scp173)
            {
                //if (Vector3.Distance(ev.Target.Position, Map.GetRandomSpawnPoint(RoleType.Scp173)) <= 8.2f)
                //{
                //
                //}
                if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-173</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=green>Chaos Insurgency</color></size>");
                }
                else if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-173</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=orange>Class D personnel</color></size>");
                }
                else if (ev.Killer.Role == RoleType.FacilityGuard)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-173</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=gray>시설 경비</color></size>");
                }
                else if (ev.Killer.Role == RoleType.None)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-173</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCadet)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-173</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#00D8FF>MTF 사관생도({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCommander)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-173</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#050099>MTF 지휘관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfLieutenant)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-173</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 부사령관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfScientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-173</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 과학자({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-173</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=yellow>Scientist</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Spectator)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-173</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>관전자</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Tutorial)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-173</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=cyan>튜토리얼</color></size>");
                }
                else
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-173</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
            }
            if (ev.Target.Role == RoleType.Scp106)
            {
                if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=green>Chaos Insurgency</color></size>");
                }
                else if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=orange>Class D personnel</color></size>");
                }
                else if (ev.Killer.Role == RoleType.FacilityGuard)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=gray>시설 경비</color></size>");
                }
                else if (ev.Killer.Role == RoleType.None)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCadet)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#00D8FF>MTF 사관생도({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCommander)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#050099>MTF 지휘관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfLieutenant)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 부사령관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfScientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 과학자({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=yellow>Scientist</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Spectator)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>관전자</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Tutorial)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=cyan>튜토리얼</color></size>");
                }
                else
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-106</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
            }
            if (ev.Target.Role == RoleType.Scp93953)
            {
                if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-53</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=green>Chaos Insurgency</color></size>");
                }
                else if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-53</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=orange>Class D personnel</color></size>");
                }
                else if (ev.Killer.Role == RoleType.FacilityGuard)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-53</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=gray>시설 경비</color></size>");
                }
                else if (ev.Killer.Role == RoleType.None)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-53</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCadet)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-53</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#00D8FF>MTF 사관생도({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCommander)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-53</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#050099>MTF 지휘관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfLieutenant)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-53</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 부사령관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfScientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-53</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 과학자({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-53</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=yellow>Scientist</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Spectator)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-53</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>관전자</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Tutorial)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-53</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=cyan>튜토리얼</color></size>");
                }
                else
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-53</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
            }
            if (ev.Target.Role == RoleType.Scp93989)
            {
                if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-89</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=green>Chaos Insurgency</color></size>");
                }
                else if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-89</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=orange>Class D personnel</color></size>");
                }
                else if (ev.Killer.Role == RoleType.FacilityGuard)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-89</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=gray>시설 경비</color></size>");
                }
                else if (ev.Killer.Role == RoleType.None)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-89</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCadet)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-89</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#00D8FF>MTF 사관생도({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfCommander)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-89</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#050099>MTF 지휘관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfLieutenant)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-89</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 부사령관({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.NtfScientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-89</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=#4374D9>MTF 과학자({unitname})</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-89</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=yellow>Scientist</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Spectator)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-89</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>관전자</color></size>");
                }
                else if (ev.Killer.Role == RoleType.Tutorial)
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-89</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=cyan>튜토리얼</color></size>");
                }
                else
                {
                    Map.Broadcast(10, $"<size=50><color=#DF4D4D>SCP-939-89</color>(이)가 <color=#2478FF>성공적</color>으로 <color=#DF4D4D>격리</color>되었습니다.\n격리 원인 : <color=white>Unknow</color></size>");
                }
            }
        }

        public void OnMtfAnnounc(AnnouncingNtfEntranceEventArgs ev)
        {
            if (ev.ScpsLeft >= 1)
            {
                Map.Broadcast(15, Plugin.Instance.Config.MtfAnnounc_scpleft.Replace("{unit-name}", ev.UnitName).Replace("{unit-number}", ev.UnitNumber.ToString()).Replace("{scpsleft}", ev.ScpsLeft.ToString()));
            }
            else
            {
                Map.Broadcast(15, Plugin.Instance.Config.MtfAnnounc_allscpcont.Replace("{unit-name}", ev.UnitName).Replace("{unit-number}", ev.UnitNumber.ToString()).Replace("{scpsleft}", ev.ScpsLeft.ToString()));
            }
        }
        
        public void OnGenOn(GeneratorActivatedEventArgs ev)
        {
            int curgen = Generator079.mainGenerator.NetworktotalVoltage + 1;
            if (curgen < 5)
            {
                Map.Broadcast(10, Plugin.Instance.Config.Gen1__4.Replace("{curgen}", curgen.ToString()));
            }
            else
            {
                Map.Broadcast(10, Plugin.Instance.Config.Gen5);
            }
        }
        
        public void OnAnnouncingDecont(AnnouncingDecontaminationEventArgs ev)
        {
            switch (ev.Id)
            {
                case 0:
                {
                    Map.Broadcast(15, Plugin.Instance.Config.Decont_15);
                    break;
                }
                case 1:
                {
                    Map.Broadcast(15, Plugin.Instance.Config.Decont_10);
                    break;
                }
                case 2:
                {
                    Map.Broadcast(15, Plugin.Instance.Config.Decont_5);
                    break;
                }
                case 3:
                {
                    Map.Broadcast(15, Plugin.Instance.Config.Decont_1);
                    break;
                }
                case 4:
                {
                    Map.Broadcast(15, Plugin.Instance.Config.Decont_30s);
                    break;
                }
            }
        }

        public void OnDeont(DecontaminatingEventArgs ev)
        {
            Map.Broadcast(15, Plugin.Instance.Config.Decont);
        }
    }
}