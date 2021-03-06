using System.Collections;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Threading;
using Core.Api.Application;
using Core.Api.Service;
using Core.Api.Tools;
using Core.Api.Utilities;
using Core.Engine.Application;
using Neo.ApplicationFramework.Attributes;
using Neo.ApplicationFramework.Common;
using Neo.ApplicationFramework.Common.Runtime;
using Neo.ApplicationFramework.Common.TypeConverters;
using Neo.ApplicationFramework.Common.Utilities;
using Neo.ApplicationFramework.Interfaces;
using Neo.ApplicationFramework.Measurement;
using Neo.ApplicationFramework.Storage.Settings;
using Neo.ApplicationFramework.Tools.Runtime;
using Neo.ApplicationFramework.Tools.Storage;

[assembly: AssemblyVersion("2.21.28.0")]
[assembly: NeoDesignerVersion("2.21.28.0")]

namespace Neo.ApplicationFramework.Generated
{
    public class Globals : GlobalsBase
    {
        private static readonly log4net.ILog m_Log = log4net.LogManager.GetLogger(typeof(Globals));

        static Globals()
        {
            
        }

        public Globals()
            : base(CreateToolManager())
        {
            m_ProjectSettings.MainScreenTitle = "Project2";
            m_ProjectSettings.Topmost = true;
            m_ProjectSettings.StartupLocation = new Point(0, 0);
            m_ProjectSettings.MaximizeOnStartup = false;
            m_ProjectSettings.MainScreenSize = new Size(480,272);
            m_ProjectSettings.BorderStyle = ScreenBorderStyle.ThreeDBorder;
            m_ProjectSettings.InputDelay = 2000;
            m_ProjectSettings.IsOnScreenKeyboardEnabled = true;
            m_ProjectSettings.KeyboardLayoutName = "US";
            m_ProjectSettings.TerminalGroup = TerminalGroup.Small;
            List<IStorageProviderSetting> storageProviderSettingsList = new List<IStorageProviderSetting>() {
                
            };
            m_ProjectSettings.StorageProviderSettings = new LocallyHostedProjectStorageProviderSettings("SQLite Database", storageProviderSettingsList, "");
            m_SystemSettings.AutomaticallyTurnOfBacklight = false;
            m_SystemSettings.BacklightTimeout = 900;
            m_SystemSettings.KeepBacklightOnIfNotifierWindowIsVisible = false;
            Dictionary<ComPort, PortMode> comPortModes = new Dictionary<ComPort, PortMode>();
            comPortModes.Add(ComPort.COM1, PortMode.Nonconfigurable); comPortModes.Add(ComPort.COM2, PortMode.rs485); comPortModes.Add(ComPort.COM3, PortMode.Nonconfigurable); comPortModes.Add(ComPort.COM4, PortMode.rs485); 
            m_SystemSettings.ComPortModes = comPortModes;
            m_SystemSettings.KeyBeep = false;
            m_SystemSettings.TimeZoneDisplayName = "(GMT-06:00) Central Time (US & Canada)";
            m_SystemSettings.TimeZoneId = 620;
            m_SystemSettings.RegionLCID = 1033;
            m_SystemSettings.AdjustForDaylightSaving = true;
            m_SystemSettings.FtpServerEnabled = false;
            m_SystemSettings.FtpServerAllowAnonymous = false;
            m_SystemSettings.FtpServerSdCardAccess = false;
            m_SystemSettings.FtpServerUsbAccess = false;
            m_SystemSettings.FtpServerDefaultDir = @"";
            m_SystemSettings.NTLMUser = @"graftel";
            m_SystemSettings.NTLMPassword = @"1402";
            m_SystemSettings.VncServerEnabled = false;
            m_SystemSettings.VncTcpPort = 5900;
            m_SystemSettings.VncHttpTcpPort = 5800;
            m_SystemSettings.VncViewOnlyPassword = @"1401";
            m_SystemSettings.VncFullAccessPassword = @"1402";
            m_SystemSettings.IsKeyPanel = false;
            m_SystemSettings.AlarmButtonShowScreenTarget = @"";
            m_SystemSettings.ScreenRotationAngle = 0;
            m_SystemSettings.BeShellMenuPassword = @"";
            m_SystemSettings.ProjectGuid = new Guid("838ab2ea-8330-4a44-8659-8df8638d1793");
        }

        
        private static IToolManager CreateToolManager()
        {
            // take simulation into account
            var coreApplication = Environment.OSVersion.Platform != PlatformID.WinCE ? (ICoreApplication)new CoreApplication(true) : (ICoreApplication)new CoreApplicationCe();
            IToolManager toolManager = new ApplicationEngineCe().CreateToolManager(true, coreApplication, Path.Combine(coreApplication.StartupPath, "Modules.cfgtool"));
            return toolManager;
        }
            

        


        /// <summary>
        /// Neo generated code - do not modify
        /// the contents of this method(s) with the code editor.
        /// </summary>
                    public static IPrinterDevice Printer1
                    {
                        get
                        {
                            IDeviceManagerServiceCF deviceManagerService = ServiceContainerCF.GetService<IDeviceManagerServiceCF>();
                            return deviceManagerService.GetOutputDevice<IPrinterDevice>();
                        }
                    }   
                    public static FilterSettingLow FilterSettingLow
                    {
                        get
                        {
                            return GetObject<FilterSettingLow>();
                        }
                    }   
                    public static StabSettingLow StabSettingLow
                    {
                        get
                        {
                            return GetObject<StabSettingLow>();
                        }
                    }   
                    public static StabSettingMid StabSettingMid
                    {
                        get
                        {
                            return GetObject<StabSettingMid>();
                        }
                    }   
                    public static FilterSettingMid FilterSettingMid
                    {
                        get
                        {
                            return GetObject<FilterSettingMid>();
                        }
                    }   
                    public static DecimalSettings DecimalSettings
                    {
                        get
                        {
                            return GetObject<DecimalSettings>();
                        }
                    }   
                    public static PersistentVariables PersistentVariables
                    {
                        get
                        {
                            return GetObject<PersistentVariables>();
                        }
                    }   
                    public static InternalSettings InternalSettings
                    {
                        get
                        {
                            return GetObject<InternalSettings>();
                        }
                    }   
                    public static DefaultSettings DefaultSettings
                    {
                        get
                        {
                            return GetObject<DefaultSettings>();
                        }
                    }   
                    public static ScriptModule1 ScriptModule1
                    {
                        get
                        {
                            return GetObject<ScriptModule1>();
                        }
                    }   
                    public static Buzzer Buzzer
                    {
                        get
                        {
                            return GetObject<Buzzer>();
                        }
                    }   
                    public static Definition Definition
                    {
                        get
                        {
                            return GetObject<Definition>();
                        }
                    }   
                    public static MainTimer MainTimer
                    {
                        get
                        {
                            return GetObject<MainTimer>();
                        }
                    }   
                    public static CalAndUpdate CalAndUpdate
                    {
                        get
                        {
                            return GetObject<CalAndUpdate>();
                        }
                    }   
                    public static SolenoidValveControl SolenoidValveControl
                    {
                        get
                        {
                            return GetObject<SolenoidValveControl>();
                        }
                    }   
                    public static Comm Comm
                    {
                        get
                        {
                            return GetObject<Comm>();
                        }
                    }   
                    public static Recording Recording
                    {
                        get
                        {
                            return GetObject<Recording>();
                        }
                    }   
                    public static DrawScreen DrawScreen
                    {
                        get
                        {
                            return GetObject<DrawScreen>();
                        }
                    }   
                    public static UnitsAndConversion UnitsAndConversion
                    {
                        get
                        {
                            return GetObject<UnitsAndConversion>();
                        }
                    }   
                    public static Reports Reports
                    {
                        get
                        {
                            return GetObject<Reports>();
                        }
                    }   
                    public static Security Security
                    {
                        get
                        {
                            return GetObject<Security>();
                        }
                    }   
                    public static Tags Tags
                    {
                        get
                        {
                            return GetObject<Tags>();
                        }
                    }   
                    public static Expressions Expressions
                    {
                        get
                        {
                            return GetObject<Expressions>();
                        }
                    }   
                    public static AlarmServer AlarmServer
                    {
                        get
                        {
                            return GetObject<AlarmServer>();
                        }
                    }   
                    public static IScreenAdapter wifiSetupManual
                    {
                        get
                        {
                            return GetObject<wifiSetupManual>().Adapter;
                        }
                    }   
                    public static IScreenAdapter wifiSearchSSID
                    {
                        get
                        {
                            return GetObject<wifiSearchSSID>().Adapter;
                        }
                    }   
                    public static IScreenAdapter WifiSetupSoftAP
                    {
                        get
                        {
                            return GetObject<WifiSetupSoftAP>().Adapter;
                        }
                    }   
                    public static IScreenAdapter WifiManualSetup
                    {
                        get
                        {
                            return GetObject<WifiManualSetup>().Adapter;
                        }
                    }   
                    public static IScreenAdapter WifiSoftAPSetup
                    {
                        get
                        {
                            return GetObject<WifiSoftAPSetup>().Adapter;
                        }
                    }   
                    public static IScreenAdapter WifiAdvanceSetup
                    {
                        get
                        {
                            return GetObject<WifiAdvanceSetup>().Adapter;
                        }
                    }   
                    public static IScreenAdapter WifiConnectToAP
                    {
                        get
                        {
                            return GetObject<WifiConnectToAP>().Adapter;
                        }
                    }   
                    public static IScreenAdapter WifiEnterPassword
                    {
                        get
                        {
                            return GetObject<WifiEnterPassword>().Adapter;
                        }
                    }   
                    public static IScreenAdapter WifiQuickSetup
                    {
                        get
                        {
                            return GetObject<WifiQuickSetup>().Adapter;
                        }
                    }   
                    public static IScreenAdapter WifiSetting
                    {
                        get
                        {
                            return GetObject<WifiSetting>().Adapter;
                        }
                    }   
                    public static IScreenAdapter SettingScreenMore
                    {
                        get
                        {
                            return GetObject<SettingScreenMore>().Adapter;
                        }
                    }   
                    public static IScreenAdapter BuzzerConfig
                    {
                        get
                        {
                            return GetObject<BuzzerConfig>().Adapter;
                        }
                    }   
                    public static IScreenAdapter CalDueDateSetting
                    {
                        get
                        {
                            return GetObject<CalDueDateSetting>().Adapter;
                        }
                    }   
                    public static IScreenAdapter popConfirm
                    {
                        get
                        {
                            return GetObject<popConfirm>().Adapter;
                        }
                    }   
                    public static IScreenAdapter popCalculator
                    {
                        get
                        {
                            return GetObject<popCalculator>().Adapter;
                        }
                    }   
                    public static IScreenAdapter DiagReportSolenoid
                    {
                        get
                        {
                            return GetObject<DiagReportSolenoid>().Adapter;
                        }
                    }   
                    public static IScreenAdapter DiagReportPress
                    {
                        get
                        {
                            return GetObject<DiagReportPress>().Adapter;
                        }
                    }   
                    public static IScreenAdapter DiagPreCheck
                    {
                        get
                        {
                            return GetObject<DiagPreCheck>().Adapter;
                        }
                    }   
                    public static IScreenAdapter DiagScreen1
                    {
                        get
                        {
                            return GetObject<DiagScreen1>().Adapter;
                        }
                    }   
                    public static IScreenAdapter ShowFile
                    {
                        get
                        {
                            return GetObject<ShowFile>().Adapter;
                        }
                    }   
                    public static IScreenAdapter FlowRateDisplay
                    {
                        get
                        {
                            return GetObject<FlowRateDisplay>().Adapter;
                        }
                    }   
                    public static IScreenAdapter SelectData
                    {
                        get
                        {
                            return GetObject<SelectData>().Adapter;
                        }
                    }   
                    public static IScreenAdapter GeneralMsgBox
                    {
                        get
                        {
                            return GetObject<GeneralMsgBox>().Adapter;
                        }
                    }   
                    public static IScreenAdapter ImportData
                    {
                        get
                        {
                            return GetObject<ImportData>().Adapter;
                        }
                    }   
                    public static IScreenAdapter KeyBoardScreen
                    {
                        get
                        {
                            return GetObject<KeyBoardScreen>().Adapter;
                        }
                    }   
                    public static IScreenAdapter SelectFileName
                    {
                        get
                        {
                            return GetObject<SelectFileName>().Adapter;
                        }
                    }   
                    public static IScreenAdapter DiagReportFlow
                    {
                        get
                        {
                            return GetObject<DiagReportFlow>().Adapter;
                        }
                    }   
                    public static IScreenAdapter QuickFillSetting
                    {
                        get
                        {
                            return GetObject<QuickFillSetting>().Adapter;
                        }
                    }   
                    public static IScreenAdapter popUnitSelect
                    {
                        get
                        {
                            return GetObject<popUnitSelect>().Adapter;
                        }
                    }   
                    public static IScreenAdapter CalSetCalDate
                    {
                        get
                        {
                            return GetObject<CalSetCalDate>().Adapter;
                        }
                    }   
                    public static IScreenAdapter CalAdjust
                    {
                        get
                        {
                            return GetObject<CalAdjust>().Adapter;
                        }
                    }   
                    public static IScreenAdapter CalInstruction
                    {
                        get
                        {
                            return GetObject<CalInstruction>().Adapter;
                        }
                    }   
                    public static IScreenAdapter CalSelectMeter
                    {
                        get
                        {
                            return GetObject<CalSelectMeter>().Adapter;
                        }
                    }   
                    public static IScreenAdapter CalBack
                    {
                        get
                        {
                            return GetObject<CalBack>().Adapter;
                        }
                    }   
                    public static IScreenAdapter StabMid
                    {
                        get
                        {
                            return GetObject<StabMid>().Adapter;
                        }
                    }   
                    public static IScreenAdapter StabLow
                    {
                        get
                        {
                            return GetObject<StabLow>().Adapter;
                        }
                    }   
                    public static IScreenAdapter StabBack
                    {
                        get
                        {
                            return GetObject<StabBack>().Adapter;
                        }
                    }   
                    public static IScreenAdapter FilterHigh
                    {
                        get
                        {
                            return GetObject<FilterHigh>().Adapter;
                        }
                    }   
                    public static IScreenAdapter FilterLow
                    {
                        get
                        {
                            return GetObject<FilterLow>().Adapter;
                        }
                    }   
                    public static IScreenAdapter FilterMid
                    {
                        get
                        {
                            return GetObject<FilterMid>().Adapter;
                        }
                    }   
                    public static IScreenAdapter FilterBack
                    {
                        get
                        {
                            return GetObject<FilterBack>().Adapter;
                        }
                    }   
                    public static IScreenAdapter DisplayDecimals
                    {
                        get
                        {
                            return GetObject<DisplayDecimals>().Adapter;
                        }
                    }   
                    public static IScreenAdapter DisplayBacklight
                    {
                        get
                        {
                            return GetObject<DisplayBacklight>().Adapter;
                        }
                    }   
                    public static IScreenAdapter DisplaySystemTime
                    {
                        get
                        {
                            return GetObject<DisplaySystemTime>().Adapter;
                        }
                    }   
                    public static IScreenAdapter DisplaySystemDate
                    {
                        get
                        {
                            return GetObject<DisplaySystemDate>().Adapter;
                        }
                    }   
                    public static IScreenAdapter DisplayBack
                    {
                        get
                        {
                            return GetObject<DisplayBack>().Adapter;
                        }
                    }   
                    public static IScreenAdapter QuickFillScreen3
                    {
                        get
                        {
                            return GetObject<QuickFillScreen3>().Adapter;
                        }
                    }   
                    public static IScreenAdapter QucikFillScreen0
                    {
                        get
                        {
                            return GetObject<QucikFillScreen0>().Adapter;
                        }
                    }   
                    public static IScreenAdapter QuickFillScreen2
                    {
                        get
                        {
                            return GetObject<QuickFillScreen2>().Adapter;
                        }
                    }   
                    public static IScreenAdapter QuickFillScreen1
                    {
                        get
                        {
                            return GetObject<QuickFillScreen1>().Adapter;
                        }
                    }   
                    public static IScreenAdapter popWrongPasscode
                    {
                        get
                        {
                            return GetObject<popWrongPasscode>().Adapter;
                        }
                    }   
                    public static IScreenAdapter popPasscode
                    {
                        get
                        {
                            return GetObject<popPasscode>().Adapter;
                        }
                    }   
                    public static IScreenAdapter RcrdFileName
                    {
                        get
                        {
                            return GetObject<RcrdFileName>().Adapter;
                        }
                    }   
                    public static IScreenAdapter RcrdInterval
                    {
                        get
                        {
                            return GetObject<RcrdInterval>().Adapter;
                        }
                    }   
                    public static IScreenAdapter RcrdTime
                    {
                        get
                        {
                            return GetObject<RcrdTime>().Adapter;
                        }
                    }   
                    public static IScreenAdapter RcrdDate
                    {
                        get
                        {
                            return GetObject<RcrdDate>().Adapter;
                        }
                    }   
                    public static IScreenAdapter BackRcrd
                    {
                        get
                        {
                            return GetObject<BackRcrd>().Adapter;
                        }
                    }   
                    public static IScreenAdapter CalScreen
                    {
                        get
                        {
                            return GetObject<CalScreen>().Adapter;
                        }
                    }   
                    public static IScreenAdapter DiagScreen
                    {
                        get
                        {
                            return GetObject<DiagScreen>().Adapter;
                        }
                    }   
                    public static IScreenAdapter PressDecayScreen
                    {
                        get
                        {
                            return GetObject<PressDecayScreen>().Adapter;
                        }
                    }   
                    public static IScreenAdapter RcrdCfgScreen
                    {
                        get
                        {
                            return GetObject<RcrdCfgScreen>().Adapter;
                        }
                    }   
                    public static IScreenAdapter FilterScreen
                    {
                        get
                        {
                            return GetObject<FilterScreen>().Adapter;
                        }
                    }   
                    public static IScreenAdapter StabilityScreen
                    {
                        get
                        {
                            return GetObject<StabilityScreen>().Adapter;
                        }
                    }   
                    public static IScreenAdapter DisplayScreen
                    {
                        get
                        {
                            return GetObject<DisplayScreen>().Adapter;
                        }
                    }   
                    public static IScreenAdapter SettingScreen
                    {
                        get
                        {
                            return GetObject<SettingScreen>().Adapter;
                        }
                    }   
                    public static IScreenAdapter MainScreen
                    {
                        get
                        {
                            return GetObject<MainScreen>().Adapter;
                        }
                    }   
                    public static IScreenAdapter StartScreen
                    {
                        get
                        {
                            return GetObject<StartScreen>().Adapter;
                        }
                    }   
        [MTAThread]
        static void Main(string[] args)
        {

            Thread.CurrentThread.Name = "NeoMainThread";

            InitializeBeHwApiLog();

            

            UserStartupMessage.SendUserStartupMessageToBeijerShell("Loading Files");
            if (!StopWatchCF.Silent)
                StopWatchCF.Send("Starting Project");
            StopWatchCF.SetTimestamp("***** Project Startup Time *****");
            while (ProcessExplorer.WaitForAttachDebugger)
            {
                Thread.Sleep(1000);
            }
            IsCompiledForCE = true;

            Instance = new Globals();
        	if (!Instance.CheckIfApplicationCanRun())
				return;

            string executingAssemblyName = Assembly.GetExecutingAssembly().FullName;
            string executablePath = typeof(Globals).Module.FullyQualifiedName;

            Instance.Go(executingAssemblyName, executablePath, args, new string[]{"Tags","AlarmServer","Expressions","Security","Reports","UnitsAndConversion","DrawScreen","Recording","Comm","SolenoidValveControl","CalAndUpdate","MainTimer","Definition","Buzzer","ScriptModule1","DefaultSettings","InternalSettings","PersistentVariables","DecimalSettings","FilterSettingMid","StabSettingMid","StabSettingLow","FilterSettingLow"}, new string[]{}, () => StartScreen);
        }

    }
}