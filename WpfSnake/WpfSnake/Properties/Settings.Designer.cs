﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfSnake.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\Resources\\Scores.xml")]
        public string ScoresFile {
            get {
                return ((string)(this["ScoresFile"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int WorldColumns {
            get {
                return ((int)(this["WorldColumns"]));
            }
            set {
                this["WorldColumns"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int WorldRows {
            get {
                return ((int)(this["WorldRows"]));
            }
            set {
                this["WorldRows"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public int WorldCellSize {
            get {
                return ((int)(this["WorldCellSize"]));
            }
            set {
                this["WorldCellSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\Resources\\Head.png")]
        public string HeadImageURI {
            get {
                return ((string)(this["HeadImageURI"]));
            }
            set {
                this["HeadImageURI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\Resources\\Body.png")]
        public string BodyImageURI {
            get {
                return ((string)(this["BodyImageURI"]));
            }
            set {
                this["BodyImageURI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\Resources\\TailZig.png")]
        public string TailZigImageURI {
            get {
                return ((string)(this["TailZigImageURI"]));
            }
            set {
                this["TailZigImageURI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\Resources\\TailZag.png")]
        public string TailZagImageURI {
            get {
                return ((string)(this["TailZagImageURI"]));
            }
            set {
                this["TailZagImageURI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\Resources\\BombLeftSpark.png")]
        public string BombLeftSparkImageURI {
            get {
                return ((string)(this["BombLeftSparkImageURI"]));
            }
            set {
                this["BombLeftSparkImageURI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\Resources\\BombRightSpark.png")]
        public string BombRightSparkImageURI {
            get {
                return ((string)(this["BombRightSparkImageURI"]));
            }
            set {
                this["BombRightSparkImageURI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\Resources\\BOOM.png")]
        public string BOOMImageURI {
            get {
                return ((string)(this["BOOMImageURI"]));
            }
            set {
                this["BOOMImageURI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\Resources\\Tail.png")]
        public string TailImageURI {
            get {
                return ((string)(this["TailImageURI"]));
            }
            set {
                this["TailImageURI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int BombTimer {
            get {
                return ((int)(this["BombTimer"]));
            }
            set {
                this["BombTimer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-8""?>
<ArrayOfScore xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <Score>
    <PlayerName>Player 1</PlayerName>
    <PlayerScore>1000</PlayerScore>
    <Date>2012-08-05T16:15:07.5260708-04:00</Date>
  </Score>
  <Score>
    <PlayerName>Art DoooD</PlayerName>
    <PlayerScore>900</PlayerScore>
    <Date>2012-08-09T23:55:32.9736819-04:00</Date>
  </Score>
  <Score>
    <PlayerName>Where is this one</PlayerName>
    <PlayerScore>154</PlayerScore>
    <Date>2012-08-11T19:47:20.2132059-04:00</Date>
  </Score>
  <Score>
    <PlayerName>Player 1</PlayerName>
    <PlayerScore>17</PlayerScore>
    <Date>2012-08-11T00:49:04.8819364-04:00</Date>
  </Score>
  <Score>
    <PlayerName>Player 1</PlayerName>
    <PlayerScore>8</PlayerScore>
    <Date>2012-08-11T19:46:37.4467598-04:00</Date>
  </Score>
  <Score>
    <PlayerName>test</PlayerName>
    <PlayerScore>8</PlayerScore>
    <Date>2012-08-11T00:50:48.9108865-04:00</Date>
  </Score>
  <Score>
    <PlayerName>Player 1</PlayerName>
    <PlayerScore>8</PlayerScore>
    <Date>2012-08-11T00:50:31.9519165-04:00</Date>
  </Score>
  <Score>
    <PlayerName>Player 1</PlayerName>
    <PlayerScore>8</PlayerScore>
    <Date>2012-08-11T00:48:47.6579512-04:00</Date>
  </Score>
</ArrayOfScore>")]
        public string HighScores {
            get {
                return ((string)(this["HighScores"]));
            }
            set {
                this["HighScores"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int BombsLaidRate {
            get {
                return ((int)(this["BombsLaidRate"]));
            }
            set {
                this["BombsLaidRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        public int BombGenerationRateMax {
            get {
                return ((int)(this["BombGenerationRateMax"]));
            }
            set {
                this["BombGenerationRateMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int TurnTime {
            get {
                return ((int)(this["TurnTime"]));
            }
            set {
                this["TurnTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public float GrowthTurnsPerOneUnit {
            get {
                return ((float)(this["GrowthTurnsPerOneUnit"]));
            }
            set {
                this["GrowthTurnsPerOneUnit"] = value;
            }
        }
    }
}
