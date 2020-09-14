using Exiled.API.Interfaces;
using System.ComponentModel;

namespace BroadcastingPlugin
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool joinuse { get; set; } = true;
        public bool leftuse { get; set; } = true;

        [Description("서버의 접속메시지를 설정합니다.")]
        public string Joinmessage { get; set; } = "<size=30><color=blue>{player.Nickname}({player})</color> 님이 게임에 입장했습니다!</size>";

        [Description("서버의 퇴장 메시지를 설정합니다.")]
        public string Leftmessage { get; set; } = "<size=30>{player.Nickname}({player})님이 게임을 포기했습니다.</size>";

        [Description("Mtf지원 메시지를 설정합니다.")]
        public string MtfAnnounc_scpleft { get; set; } = "<size=50><color=#2478FF>기동특무부대</color> Epsilon-11소속 <color=#2478FF>{unit-name}-{unit-number}</color>(이)가 시설에 진입했습니다.\n현재 <color=#DF4D4D>격리</color>를 기다리는 <color=#DF4D4D>개체수</color> : {scpsleft}</size>";

        public string MtfAnnounc_allscpcont { get; set; } = "<size=50><color=#2478FF>기동특무부대</color> Epsilon-11소속 <color=#2478FF>{unit-name}-{unit-number}</color>(이)가 시설에 진입했습니다.\n현재 <color=#DF4D4D>격리</color>가 필요한 개체가 없습니다.</size>";

        [Description("발전기가 작동되었을때의 메시지를 설정합니다.")]
        public string Gen1__4 { get; set; } = "<size=50><color=red>발전기</color> 5개중 <color=red>{curgen}개(이)가</color> 작동되었습니다.</size>";

        public string Gen5 { get; set; } = "<size=50><color=red>발전기</color> 5개중 <color=red>5개(이)가</color> 작동되었습니다.</size>";
        
        [Description("저위험군의 폐쇄 메시지를 설정합니다.")]
        public string Decont_15 { get; set; } = "<size=50>저위험군 폐쇄까지 <color=red>15분</color> 남았습니다.\n모든 유기물들은 <color=red>붕괴</color>를 막기위해 <color=red>제거</color>되어야 합니다.</size>";
        public string Decont_10 { get; set; } = "<size=50>저위험군 폐쇄까지 <color=red>10분</color> 남았습니다.</size>";
        public string Decont_5 { get; set; } = "<size=50>저위험군 폐쇄까지 <color=red>5분</color> 남았습니다.</size>";
        public string Decont_1 { get; set; } = "<size=50>저위험군 폐쇄까지 <color=red>1분</color> 남았습니다.</size>";
        public string Decont_30s { get; set; } = "<size=50>저위험군 폐쇄까지 <color=red>30초</color> 남았습니다.\n모든 저위험군의 <color=red>검문소</color>의 문이 영구적으로 열렸습니다. <color=red>긴급히 대피</color>하십시오.</size>";
        public string Decont { get; set; } = "<size=50>저위험군 폐쇄가 완료되었습니다.\n모든 유기물들의 <color=red>제거</color>가 <color=red>시작</color>됩니다.</size>";

        [Description("알파탄두의 메시지를 설정합니다.")]
        public string AlphaStart_notresumed { get; set; } = "<size=50><color=red>알파탄두</color> 폭★파 절차가 <color=red>실행</color>되었습니다.\n<color=red>시설</color>의 지하가 <color=yellow>{sec}초</color> 내에 <color=red>폭★발</color>합니다.</size>";
        
        public string AlphaStart_resumed { get; set; } = "<size=50><color=red>알파탄두</color> 폭★파 절차가 <color=red>다시 실행</color>되었습니다.\n<color=red>시설</color>의 지하가 <color=yellow>{sec}초</color> 내에 <color=red>폭★발</color>합니다.</size>";

        public string AlphaStop { get; set; } = "<size=50><color=red>알파탄두</color> 폭★파 절차가 <color=red>취소</color>되었습니다.\n취소한 사람 : {player.Nickname}</size>";
        
        [Description("라운드 시작시 메시지를 설정합니다.")]
        
        public string Roundstartmessage { get; set; } = "<size=50>라운드가 시작되었습니다.</size>";
        
        [Description("라운드 종료 메시지를 설정합니다.")]
        
        public string RoundEndmessage { get; set; } = "<size=50>라운드가 종료되었습니다.</size>";
        
        [Description("라운드가 끝날시 정전을 이르킬까요?")]
        
        public bool AllLightoff { get; set; } = false;

        [Description("라운드가 끝날시 Cassie로 나오는 단어를 설정할건가요? 만약 설정하면 무엇을 나오게 할건가요?")]

        public bool cassieStart { get; set; } = false;

        public string cassieword { get; set; } = "Xmas_JingleBells";
    }
}