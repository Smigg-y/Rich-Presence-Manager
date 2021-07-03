using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Updated_Client
{
    internal sealed partial class Client : MaterialForm
    {
        // Create Context Menu;
        private readonly ContextMenu _context = new ContextMenu();

        // Create RPC;
        private DiscordRpcClient _client;

        // Create State Checks;
        private bool _firstState = true;
        private bool _stateRunning;

        // Cache Theme Info;
        private Primary _primaryNorm;
        private Primary _primaryLight;
        private Primary _primaryDark;
        private Accent _accent;
        private TextShade _textShade;

        // Thread Protection;
        private static bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired)
                c.Invoke(new MethodInvoker(() => a()));
            else
                return false;

            return true;
        }

        // Reference Skin Manager;
        private readonly MaterialSkinManager _skin = MaterialSkinManager.Instance;

        internal Client()
        {
            InitializeComponent();

            Timer.Start();

            // Set Theme and Color Scheme of Form;
            _skin.AddFormToManage(this);
            _skin.Theme = MaterialSkinManager.Themes.DARK;

            _skin.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue700, Accent.Blue100,
                TextShade.WHITE);
            _primaryNorm = Primary.Blue800;
            _primaryDark = Primary.Blue900;
            _primaryLight = Primary.Blue700;
            _accent = Accent.Blue100;
            _textShade = TextShade.WHITE;

            // Create Buttons and Event Handlers for Context Menu;
            var showApp = _context.MenuItems.Add("&Show Application");
            showApp.Click += ShowApp_Click;

            var exitApp = _context.MenuItems.Add("&Exit Application");
            exitApp.Click += ExitApp_Click;

            Notify.ContextMenu = _context;

            // Get process name ( in case someone has renamed the file );
            // Build file path and add settings file name;
            var procName = Process.GetCurrentProcess().ProcessName;
            var processModule = Process.GetCurrentProcess().MainModule;
            if (processModule == null) return;

            var fullPath = processModule.FileName.Replace(procName + ".exe", "settings.json");

            // Check if the settings file exists;
            if (!File.Exists(fullPath)) return;

            var jsonString = File.ReadAllText(fullPath);

            var data = JsonSerializer.Deserialize<Data>(jsonString);
            if (data == null) return;

            ClientID_Box.Text = data.ClientId;
            Details_Box.Text = data.Details;
            State_Box.Text = data.State;
            LImageKey_Box.Text = data.LargeImageKey;
            LImageText_Box.Text = data.LargeImageText;
            SImageKey_Box.Text = data.SmallImageKey;
            SImageText_Box.Text = data.SmallImageText;
            TimestampOn.Checked = data.TimestampEnabled;
            _skin.ColorScheme = new ColorScheme(data.Theme.Primary, data.Theme.PrimaryDark, data.Theme.PrimaryLight,
                data.Theme.Accent, data.Theme.TextShade);
        }

        // Enable Dragging of the Window when the Top-Most Label is being Held;
        private void WindowLbl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        // Show Form and Hide Notify Icon;
        private void Notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Notify.Visible = false;
        }

        // Show Form and Hide Notify Icon;
        private void ShowApp_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Notify.Visible = false;
        }

        // Close Form;
        private void ExitApp_Click(object sender, EventArgs e) => Close();

        // Start The Client on First Run and Update it otherwise;
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (_firstState)
            {
                // if ClientID is empty then don't continue;
                if (ClientID_Box.Text.Equals("")) return;

                _client = new DiscordRpcClient(ClientID_Box.Text)
                {
                    Logger = new ConsoleLogger() {Level = LogLevel.None}
                };

                _client.OnReady += (s, ea) =>
                {
                    // Update States;
                    _firstState = false;
                    _stateRunning = true;

                    var eventStr =
                        "--------------------------------------------------------------------------------\r\n"
                        + "READY EVENT\r\n\r\n"
                        + $"TIME: {ea.TimeCreated}\r\n"
                        + $"MESSAGE: {ea.Type}\r\n"
                        + $"VERSION: {ea.Version}\r\n\r\n"
                        + $"USER: {ea.User.Username}#{ea.User.Discriminator}\r\n"
                        + $"PREMIUM STATUS: {ea.User.Premium}\r\n"
                        + $"USER ID: {ea.User.ID}\r\n"
                        + $"AVATAR: {ea.User.GetAvatarURL(User.AvatarFormat.PNG, User.AvatarSize.x1024)}\r\n"
                        + $"FLAGS: {ea.User.Flags}\r\n"
                        + "--------------------------------------------------------------------------------\r\n\r\n";

                    UpdateInfo(eventStr);
                };

                _client.Initialize();

                // Set Presence and check if we should add a timestamp;
                switch (TimestampOn.Checked)
                {
                    case true:
                        _client.SetPresence(new RichPresence()
                        {
                            Details = Details_Box.Text,
                            State = State_Box.Text,
                            Assets = new Assets()
                            {
                                LargeImageKey = LImageKey_Box.Text,
                                LargeImageText = LImageText_Box.Text,
                                SmallImageKey = SImageKey_Box.Text,
                                SmallImageText = SImageText_Box.Text
                            },
                            Timestamps = new Timestamps()
                            {
                                Start = DateTime.UtcNow
                            }
                        });
                        break;
                    case false:
                        _client.SetPresence(new RichPresence()
                        {
                            Details = Details_Box.Text,
                            State = State_Box.Text,
                            Assets = new Assets()
                            {
                                LargeImageKey = LImageKey_Box.Text,
                                LargeImageText = LImageText_Box.Text,
                                SmallImageKey = SImageKey_Box.Text,
                                SmallImageText = SImageText_Box.Text
                            }
                        });
                        break;
                }
            }

            _client.OnPresenceUpdate += (s, ea) =>
            {
                // Update States;
                _firstState = false;
                _stateRunning = true;

                var eventStr =
                    "--------------------------------------------------------------------------------\r\n"
                    + "PRESENCE UPDATE EVENT\r\n\r\n"
                    + $"TIME: {ea.TimeCreated}\r\n"
                    + $"MESSAGE: {ea.Type}\r\n\r\n"
                    + $"APPLICATION ID: {ea.ApplicationID}\r\n"
                    + $"APPLICATION NAME: {ea.Name}\r\n\r\n"
                    + $"STATE: {ea.Presence.State}\r\n"
                    + $"DETAILS: {ea.Presence.Details}\r\n"
                    + $"LARGE IMAGE KEY: {ea.Presence.Assets.LargeImageKey}\r\n"
                    + $"LARGE IMAGE ID: {ea.Presence.Assets.LargeImageID}\r\n"
                    + $"LARGE IMAGE TEXT: {ea.Presence.Assets.LargeImageText}\r\n"
                    + $"LARGE IMAGE KEY: {ea.Presence.Assets.SmallImageKey}\r\n"
                    + $"LARGE IMAGE ID: {ea.Presence.Assets.SmallImageID}\r\n"
                    + $"LARGE IMAGE TEXT: {ea.Presence.Assets.SmallImageText}\r\n"
                    + $"TIMESTAMP START: {ea.Presence.Timestamps.Start}\r\n"
                    + "--------------------------------------------------------------------------------\r\n\r\n";

                UpdateInfo(eventStr);
            };

            // Update Text;
            StartBtn.Text = @"Update Client";

            // Update and Sync Presence;
            _client.UpdateDetails(Details_Box.Text);
            _client.UpdateState(State_Box.Text);
            _client.UpdateLargeAsset(LImageKey_Box.Text, LImageText_Box.Text);
            _client.UpdateSmallAsset(SImageKey_Box.Text, SImageText_Box.Text);

            if (TimestampOn.Checked)
                _client.UpdateStartTime(DateTime.UtcNow);
            else
                _client.UpdateClearTime();

            _client.SynchronizeState();
        }

        // Thread Protection;
        private void UpdateInfo(string text)
        {
            if (ControlInvokeRequired(InfoTextbox, () => UpdateInfo(text))) return;

            InfoTextbox.Text += text;
        }

        // Keep Button centered when its text gets updated;
        private void StartBtn_SizeChanged(object sender, EventArgs e)
        {
            StartBtn.Left = (ClientSize.Width - StartBtn.Width) / 2;
        }

        // Minimise to Task Bar;
        private void Client_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized) return;

            Hide();
            Notify.Visible = true;
        }

        // Themes;
        private void DarkThemeBtn_Click(object sender, EventArgs e)
        {
            _skin.ColorScheme = new ColorScheme(Primary.Grey700, Primary.Grey800, Primary.Grey600, Accent.Amber700,
                TextShade.WHITE);
            _primaryNorm = Primary.Grey700;
            _primaryDark = Primary.Grey800;
            _primaryLight = Primary.Grey600;
            _accent = Accent.Amber700;
            _textShade = TextShade.WHITE;
        }

        private void RedThemeBtn_Click(object sender, EventArgs e)
        {
            _skin.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red700, Accent.Red100,
                TextShade.WHITE);
            _primaryNorm = Primary.Red800;
            _primaryDark = Primary.Red900;
            _primaryLight = Primary.Red700;
            _accent = Accent.Red100;
            _textShade = TextShade.WHITE;
        }

        private void GreenThemeBtn_Click(object sender, EventArgs e)
        {
            _skin.ColorScheme = new ColorScheme(Primary.LightGreen800, Primary.LightGreen900, Primary.LightGreen700,
                Accent.LightGreen100, TextShade.WHITE);
            _primaryNorm = Primary.LightGreen800;
            _primaryDark = Primary.LightGreen900;
            _primaryLight = Primary.LightGreen700;
            _accent = Accent.LightGreen100;
            _textShade = TextShade.WHITE;
        }

        private void PurpleThemeBtn_Click(object sender, EventArgs e)
        {
            _skin.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple700,
                Accent.DeepPurple100, TextShade.WHITE);
            _primaryNorm = Primary.Purple800;
            _primaryDark = Primary.Purple900;
            _primaryLight = Primary.Purple700;
            _accent = Accent.DeepPurple100;
            _textShade = TextShade.WHITE;
        }

        private void BlueThemeBtn_Click(object sender, EventArgs e)
        {
            _skin.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue700, Accent.Blue100,
                TextShade.WHITE);
            _primaryNorm = Primary.Blue800;
            _primaryDark = Primary.Blue900;
            _primaryLight = Primary.Blue700;
            _accent = Accent.Blue100;
            _textShade = TextShade.WHITE;
        }

        private void YellowThemeBtn_Click(object sender, EventArgs e)
        {
            _skin.ColorScheme = new ColorScheme(Primary.Yellow700, Primary.Yellow800, Primary.Yellow600,
                Accent.Yellow100, TextShade.WHITE);
            _primaryNorm = Primary.Yellow700;
            _primaryDark = Primary.Yellow800;
            _primaryLight = Primary.Yellow600;
            _accent = Accent.Yellow100;
            _textShade = TextShade.WHITE;
        }

        // Event messages;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!_stateRunning) return;

            _client.OnClose += (s, ea) =>
            {
                var eventStr =
                    "--------------------------------------------------------------------------------\r\n"
                    + "CLOSE EVENT\r\n\r\n"
                    + $"TIME: {ea.TimeCreated}\r\n"
                    + $"MESSAGE: {ea.Type}\r\n\r\n"
                    + $"CLOSE CODE: {ea.Code}\r\n"
                    + $"CLOSE REASON: {ea.Reason}\r\n"
                    + "--------------------------------------------------------------------------------\r\n\r\n";

                UpdateInfo(eventStr);
            };

            _client.OnConnectionEstablished += (s, ea) =>
            {
                var eventStr =
                    "--------------------------------------------------------------------------------\r\n"
                    + "CONNECTION ESTABLISHED EVENT\r\n\r\n"
                    + $"TIME: {ea.TimeCreated}\r\n"
                    + $"MESSAGE: {ea.Type}\r\n\r\n"
                    + $"PIPELINE: {ea.ConnectedPipe}\r\n"
                    + "--------------------------------------------------------------------------------\r\n\r\n";

                UpdateInfo(eventStr);
            };

            _client.OnConnectionFailed += (s, ea) =>
            {
                var eventStr =
                    "--------------------------------------------------------------------------------\r\n"
                    + "CONNECTION FAILED EVENT\r\n\r\n"
                    + $"TIME: {ea.TimeCreated}\r\n"
                    + $"MESSAGE: {ea.Type}\r\n\r\n"
                    + $"PIPELINE: {ea.FailedPipe}\r\n"
                    + "--------------------------------------------------------------------------------\r\n\r\n";

                UpdateInfo(eventStr);
            };

            _client.OnError += (s, ea) =>
            {
                var eventStr =
                    "--------------------------------------------------------------------------------\r\n"
                    + "ERROR EVENT\r\n\r\n"
                    + $"TIME: {ea.TimeCreated}\r\n"
                    + $"MESSAGE: {ea.Type}\r\n\r\n"
                    + $"ERROR CODE: {ea.Code}\r\n"
                    + $"ERROR MESSAGE: {ea.Message}\r\n"
                    + "--------------------------------------------------------------------------------\r\n\r\n";

                UpdateInfo(eventStr);
            };

            _client.OnSubscribe += (s, ea) =>
            {
                var eventStr =
                    "--------------------------------------------------------------------------------\r\n"
                    + "EVENT SUBSCRIBE EVENT\r\n\r\n"
                    + $"TIME: {ea.TimeCreated}\r\n"
                    + $"MESSAGE: {ea.Type}\r\n\r\n"
                    + $"EVENT: {ea.Event}\r\n"
                    + "--------------------------------------------------------------------------------\r\n\r\n";

                UpdateInfo(eventStr);
            };

            _client.OnUnsubscribe += (s, ea) =>
            {
                var eventStr =
                    "--------------------------------------------------------------------------------\r\n"
                    + "EVENT UNSUBSCRIBE EVENT\r\n\r\n"
                    + $"TIME: {ea.TimeCreated}\r\n"
                    + $"MESSAGE: {ea.Type}\r\n\r\n"
                    + $"EVENT: {ea.Event}\r\n"
                    + "--------------------------------------------------------------------------------\r\n\r\n";

                UpdateInfo(eventStr);
            };
        }

        // Save settings to file;
        private void SaveFile_Btn_Click(object sender, EventArgs e)
        {
            var procName = Process.GetCurrentProcess().ProcessName;
            var processModule = Process.GetCurrentProcess().MainModule;
            if (processModule == null) return;

            var fullPath = processModule.FileName.Replace(procName + ".exe", "settings.json");

            var theme = new Theme
            {
                Primary = _primaryNorm,
                PrimaryDark = _primaryDark,
                PrimaryLight = _primaryLight,
                Accent = _accent,
                TextShade = _textShade
            };

            var data = new Data
            {
                ClientId = ClientID_Box.Text,
                Details = Details_Box.Text,
                State = State_Box.Text,
                LargeImageKey = LImageKey_Box.Text,
                LargeImageText = LImageText_Box.Text,
                SmallImageKey = SImageKey_Box.Text,
                SmallImageText = SImageText_Box.Text,
                TimestampEnabled = TimestampOn.Checked,
                Theme = theme
            };

            var jsonString = JsonSerializer.Serialize(data);

            File.WriteAllText(fullPath, jsonString);
        }

        // Load Settings from file;
        private void LoadFile_Btn_Click(object sender, EventArgs e)
        {
            var procName = Process.GetCurrentProcess().ProcessName;
            var processModule = Process.GetCurrentProcess().MainModule;
            if (processModule == null) return;

            var fullPath = processModule.FileName.Replace(procName + ".exe", "settings.json");

            if (!File.Exists(fullPath)) return;

            var jsonString = File.ReadAllText(fullPath);

            var data = JsonSerializer.Deserialize<Data>(jsonString);

            if (data == null) return;

            ClientID_Box.Text = data.ClientId;
            Details_Box.Text = data.Details;
            State_Box.Text = data.State;
            LImageKey_Box.Text = data.LargeImageKey;
            LImageText_Box.Text = data.LargeImageText;
            SImageKey_Box.Text = data.SmallImageKey;
            SImageText_Box.Text = data.SmallImageText;
            TimestampOn.Checked = data.TimestampEnabled;
            _skin.ColorScheme = new ColorScheme(data.Theme.Primary, data.Theme.PrimaryDark,
                data.Theme.PrimaryLight, data.Theme.Accent, data.Theme.TextShade);
        }

        // Stop Presence without closing application;
        private void KillClientBtn_Click(object sender, EventArgs e)
        {
            if (!_stateRunning) return;

            _client.ClearPresence();
            _client.Dispose();

            _firstState = true;
            _stateRunning = false;
            StartBtn.Text = @"Start Client";
        }
    }

    // get and set JSON Data;
    public sealed class Theme
    {
        public Primary Primary { get; set; }
        public Primary PrimaryDark { get; set; }
        public Primary PrimaryLight { get; set; }
        public Accent Accent { get; set; }
        public TextShade TextShade { get; set; }
    }

    public sealed class Data
    {
        public string ClientId { get; set; }
        public string Details { get; set; }
        public string State { get; set; }
        public string LargeImageKey { get; set; }
        public string LargeImageText { get; set; }
        public string SmallImageKey { get; set; }
        public string SmallImageText { get; set; }
        public bool TimestampEnabled { get; set; }
        public Theme Theme { get; set; }
    }
}