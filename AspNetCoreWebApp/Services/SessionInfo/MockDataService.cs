using System.Collections.Generic;

namespace AspNetCoreWebApp.Services.SessionInfo
{
    public class MockDataService : IDataService
    {
        public IEnumerable<Models.SessionInfo> FetchData()
        {
            return new List<Models.SessionInfo>()
            {
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) Overview : What is .NET",
                    Description = "介紹 .NET，並詳說明此次 .NET Conf Local Event Taichung 議程。",
                    Speaker = "Duran Hsieh",
                    SpeakerImage = "duran_hsieh.jpg"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) ASP.NET Core - Security and Identity",
                    Description = "介紹 ASP.NET Core 2.0 Security 與 Identity 大綱，包含 Authorization Policies、Cookie Auth、 TOTP.  此課程也包含實作 demo。",
                    Speaker = "Money Yu",
                    SpeakerImage = "money_yu.jpg"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) Disruptor.NET - 高性能非同步事件處理框架",
                    Description = "※ 淺談高並發與多執行緒 ※ 什麼是Disruptor ※ Disruptor的架構設計 ※ 適合的應用場景",
                    Speaker = "Jed Lin",
                    SpeakerImage = "jed_lin.jpg"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) 使用 Akka.NET 建立響應式應用程式",
                    Description = "※ Reactive Manifesto & Architecture ※ Akka.NET & .NET Core ※ Put it into REAL : Integrating React & SignalR",
                    Speaker = "Blackie",
                    SpeakerImage = "blackie.jpg"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) Garbage Collection in .NET",
                    Description = "記憶體回收在 .NET 的世界中是一個神秘區塊，我們好像了解GC，但又好像很不熟悉...而且還對我們的系統有著直接的效能影響，今天我們來揭開這神秘的面紗吧！",
                    Speaker = "饅頭",
                    SpeakerImage = "饅頭.webp"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) 使用 ASP.NET Blazor 開發 SPA 網頁應用程式",
                    Description = "前陣子 ASP.NET Blazor 的出現，在整個 ASP.NET 市場投下震撼彈。只要你會寫 C# / ASP.NET Core，不需要撰寫 JavaScript 也可以成為一個「前端工程師」。這話說起來有點奇怪，但確實如此，由於 WebAssembly 的出現，讓後端開發者也能用熟悉的程式語言與框架，開發出即時互動的 SPA 網站應用程式。本次演說，將帶來 .NET 最新最夯的 Blazor 框架，讓你迅速了解如何利用 Blazor 打造即時互動的網站應用程式。",
                    Speaker = "黃保翕 (Will Huang)",
                    SpeakerImage = "will_huang.jpg"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) 使用 .NET Standard 開發跨平台應用程式",
                    Description = "微軟近期所推出的 .NET Standard ，而沒多久又將 .NET Standard 推向 2.0 版，再加上 .NET Core 2.1 與 ASP.NET Core 2.1 的相繼推出、以及改變應用程式佈署模式的容器服務的出現，且微軟更是讓 Docker 與 Windows Server 2016 無縫的整合，對於許多工具像是 Visual Studio／VSCode／Visual Studio for MAC 與開發平台不斷地釋出、更新，不管是開發相關、或者持續交付（VSTS）、Containers，這些布局都說明了微軟對於未來的熊熊野心。",
                    Speaker = "Gelis Wu",
                    SpeakerImage = "gelis_wu.jpg"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) 利用ML.NET整合機器學習至應用程式",
                    Description = "AI在生活中漸漸無所不在，市面上也越來越多服務串接及整合AI，然而AI聰明取決於Prediction Model的建立，但是AI建立模型只能用R、Python嗎? ML.NET是為.NET開發人員構建的機器學習框架，使用ML.NET能夠輕鬆的將自定義機器學習整合到您的應用程式之中。這堂課將直接展示Machine Learning with .NET的威力，AI有夠潮，一起AI吧！",
                    Speaker = "Alan Tsai & Alan Liu",
                    SpeakerImage = "alan_liu.webp"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) Message Queue Based RPC",
                    Description = "不論是微服務架構，或是分散式系統，服務之間的可靠通訊永遠是最重要的架構議題。如果通訊的方式是同步 (synchronized) 的，通常都用 HTTP + REST，如果通訊方式要求要非同步模式 (async) 的話，通常都會使用訊息貯列 (message queue)，同時附帶極高的可靠度 (即使後端掛掉都不用擔心的高可靠度)，以及能夠有效的均衡後端的附載。",
                    Speaker = "Andrew Wu",
                    SpeakerImage = "andrew_wu.webp"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) Introducing Functional Programming in C#",
                    Description = "近幾年在很多大型研討會中，Functional Programming 的相關議題所佔的比例也逐年提高。 而 C# 也從第 6 版開始，加強對於 FP 風格的支援程度，尤其是即將推出的 C# 8，對於 FP 支援更加完整；即使 C# 支援 FP 風格語法，並不代表能活用 FP，這必須改變原有思考方式與寫程式習慣，才能真正發揮出 FP 威力。",
                    Speaker = "Kevin Yang &  Sam Xiao",
                    SpeakerImage = "sam_xiao.jpg"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) 智慧邊界 - 從機器學習開始",
                    Description = "在過去幾年中，人工智慧與機器學習已經再也不是只能適用在實驗室中的技術了，無論是雲端或是地端的系統，人工智慧已經逐漸變成不可或缺的一環，也越來越容易開發與訓練。了解人工智慧與機器學習已是身為當今開發者必備的技能之一。在此議程中，將會帶來如何在雲端和地端利用 Azure 來進行機器學習",
                    Speaker = "Ning",
                    SpeakerImage = "ning.jpg"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) .NET Core + Azure DevOps 應用於企業開發",
                    Description = ".NET Core 已經出到2.1 版，即將推出3.0，企業是否該選擇導入 .NET Core作為內部開發標準，導入前應該注意哪些事項？降低整體導入的阻力，又或是真的需要採用 .NET Core開發嗎? 善用Azure DevOps讓.NET Core 發揮更大優勢，並結合Container，提升.NET Core在企業內部持續交付和持續整合優勢",
                    Speaker = "Edward Kuo",
                    SpeakerImage = "edward_kuo.webp"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) 使用 Dependency Injection 撰寫簡潔 C# 程式碼原來這麼簡單",
                    Description = "依賴注入 (Dependency Injection, DI) 是一種用於解決程式依賴性設計模式，對於要克服常態的需求變動、單元測試的撰寫、或者想要設計出更清晰易懂的程式架構，透過依賴注入的設計模式，能協助您產出更容易維護的應用程式架構。",
                    Speaker = "Poy Chang",
                    SpeakerImage = "poy_chang.jpg"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) (資料科學議程) TBD",
                    Description = "TBD",
                    Speaker = "Tricia Tsai",
                    SpeakerImage = "tricia_tsai.jpg"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) 網關攻略 - 淺談 .NET Core API Gateway Ocelot",
                    Description = "TBD",
                    Speaker = "Sky",
                    SpeakerImage = "sky.webp"
                },
                new Models.SessionInfo()
                {
                    SessionName = "(Mock) 初探 F# 函數式程式設計",
                    Description = "「函數式程式設計」一詞近年來熱度飆高，在業界有快速發展的趨勢。許多程式語言爭相加入函數式特性，就連 .NET 家族語言也不例外。這是具有 60 年歷史的技術，影響範圍涉及 C#, F#, F* 和 Q#。F# 和函數式程式設計到底有何神奇魔力？讓我們來帶您一探究竟！",
                    Speaker = "Carl Su",
                    SpeakerImage = "carl_su.jpg"
                }
            };
        }
    }
}
