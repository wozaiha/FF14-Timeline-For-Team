
        public const string CombatStartNowEN = "0039:战斗开始！";

        public static readonly IList<AnalyzeKeyword> KeywordsEN = new[]
        {
            new AnalyzeKeyword() { Keyword = "[EX] Added", Category = KewordTypes.Record },
            new AnalyzeKeyword() { Keyword = "[EX] POS", Category = KewordTypes.Record },
            new AnalyzeKeyword() { Keyword = "[EX] Beacon", Category = KewordTypes.Record },
            new AnalyzeKeyword() { Keyword = "之灵", Category = KewordTypes.Pet },
            new AnalyzeKeyword() { Keyword = "朝日小仙女", Category = KewordTypes.Pet },
            new AnalyzeKeyword() { Keyword = "夕月小仙女", Category = KewordTypes.Pet },
            new AnalyzeKeyword() { Keyword = "宝石兽", Category = KewordTypes.Pet },
            new AnalyzeKeyword() { Keyword = "浮空塔", Category = KewordTypes.Pet },
            new AnalyzeKeyword() { Keyword = "巴哈姆特之灵", Category = KewordTypes.Pet },
            new AnalyzeKeyword() { Keyword = "地星", Category = KewordTypes.Pet },
            new AnalyzeKeyword() { Keyword = "正在咏唱", Category = KewordTypes.Cast },
            new AnalyzeKeyword() { Keyword = "正在发动", Category = KewordTypes.Cast },
            new AnalyzeKeyword() { Keyword = "starts using", Category = KewordTypes.Cast },
            new AnalyzeKeyword() { Keyword = "HP at", Category = KewordTypes.HPRate },
            new AnalyzeKeyword() { Keyword = "[EX] Added new combatant", Category = KewordTypes.Added },
            new AnalyzeKeyword() { Keyword = "] 1B:", Category = KewordTypes.Marker },
            new AnalyzeKeyword() { Keyword = "陷入了“猎物”效果", Category = KewordTypes.Marker },
            new AnalyzeKeyword() { Keyword = "] 1A:", Category = KewordTypes.Effect },
            new AnalyzeKeyword() { Keyword = "00:0044:", Category = KewordTypes.Dialogue },
            new AnalyzeKeyword() { Keyword = "00:0839:", Category = KewordTypes.Dialogue },
            new AnalyzeKeyword() { Keyword = ImportLog, Category = KewordTypes.Start },
            new AnalyzeKeyword() { Keyword = "/spespetime -a start", Category = KewordTypes.Start },
            new AnalyzeKeyword() { Keyword = "00:0039:战斗开始！", Category = KewordTypes.Start },
            new AnalyzeKeyword() { Keyword = "00:0039:距离战斗开始还有5秒！", Category = KewordTypes.TimelineStart },
            new AnalyzeKeyword() { Keyword = "/spespetime -a end", Category = KewordTypes.End },
            new AnalyzeKeyword() { Keyword = "结束了", Category = KewordTypes.End },
            new AnalyzeKeyword() { Keyword = "00:0839:请掷骰。", Category = KewordTypes.End },
            new AnalyzeKeyword() { Keyword = WipeoutLog, Category = KewordTypes.End },
            new AnalyzeKeyword() { Keyword = "发动了", Category = KewordTypes.Action },
        };

        public static readonly Dictionary<string, Regex> AnalyzeRegexedEN = new Dictionary<string, Regex>()
        {
            {
                nameof(ActionRegex),
                CreateRegex(@"\[.+?\] 00:....:(?<actor>.+?)发动了\“(?<skill>.+?)\”\。$")
            },
            {
                nameof(AddedRegex),
                CreateRegex(@":[EX] Added new combatant. name=(?<actor>.+) X=")
            },
            {
                nameof(CastRegex),
                CreateRegex(@"\[.+?\] 00:....:(?<actor>.+?)(正在发动|正在咏唱)\“(?<skill>.+?)\”\。$")
            },
            {
                nameof(HPRateRegex),
                CreateRegex(@"\[.+?\] ..:(?<actor>.+?) HP at (?<hprate>\d+?)%")
            },
            {
                nameof(StartsUsingRegex),
                CreateRegex(@"14:....:(?<actor>.+?) starts using (?<skill>.+?) on (?<target>.+?)\.$")
            },
            {
                nameof(StartsUsingUnknownRegex),
                CreateRegex(@"14:....:(?<actor>.+?) starts using (?<skill>.+?) on Unknown\.$")
            },
            {
                nameof(DialogRegex),
                CreateRegex(@"00:(0044|0839):(?<dialog>.+?)$")
            },
            {
                nameof(CombatStartRegex),
                CreateRegex(@"00:(0038|0039):(?<discription>.+?)$")
            },
            {
                nameof(CombatEndRegex),
                CreateRegex(@"00:....:(?<discription>.+?)$")
            },
            {
                nameof(EffectRegex),
                CreateRegex(@"1A:(?<victim>.+?) gains the effect of (?<effect>.+?) from (?<actor>.+?) for (?<duration>[0-9\.]*?) Seconds.$")
            },
            {
                nameof(MarkerRegex),
                CreateRegex(@"1B:(?<id>.{8}):(?<target>.+?):0000:....:(?<type>....):0000:0000:0000:$")
            },
            {
                nameof(MarkingRegex),
                CreateRegex(@"00:(?<id>....):(?<target>.+?)陷入了“猎物”效果\。$")
            },
        };

