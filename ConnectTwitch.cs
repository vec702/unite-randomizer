using System.Diagnostics;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using UniteWheel;

namespace UNITE_Randomizer
{
    public partial class ConnectTwitch : Form
    {
        private static string CLIENT_ID = "please generate your own id :)";
        private string AUTH_URL = $"https://id.twitch.tv/oauth2/authorize?response_type=token&client_id={CLIENT_ID}&redirect_uri=http://localhost&scope=chat%3Aedit+chat%3Aread&state=random1zer";
        private TcpClient? client;
        private StreamReader? reader;
        private StreamWriter? writer;

        private string username = string.Empty;
        private string channel = string.Empty;
        private string oauth = string.Empty;

        public event EventHandler<string>? UpdateToolStripLabel;

        public ConnectTwitch()
        {
            InitializeComponent();
        }

        private async Task StartHttpListenerAsync()
        {
            var listener = new HttpListener();
            listener.Prefixes.Add("http://localhost/");
            listener.Start();

            try
            {
                var initialContext = await listener.GetContextAsync();
                var initialResponse = initialContext.Response;
                string responseString = @"
                <html><body><script>
                    var hash = window.location.hash.substring(1);
                    var queryParams = '?' + hash;
                    window.location.href = 'http://localhost/' + queryParams;
                </script>Please wait...</body></html>";
                var buffer = Encoding.UTF8.GetBytes(responseString);
                initialResponse.ContentLength64 = buffer.Length;
                await initialResponse.OutputStream.WriteAsync(buffer, 0, buffer.Length);
                initialResponse.OutputStream.Close();
                var tokenContext = await listener.GetContextAsync();
                var request = tokenContext.Request;
                var tokenResponse = tokenContext.Response;
                var token = request.QueryString["access_token"];
                if (!string.IsNullOrEmpty(token)) oauth = $"oauth:{token}";
                responseString = "<html><body>Authentication successful. You can now close this window.</body></html>";
                buffer = Encoding.UTF8.GetBytes(responseString);
                tokenResponse.ContentLength64 = buffer.Length;
                await tokenResponse.OutputStream.WriteAsync(buffer, 0, buffer.Length);
                tokenResponse.OutputStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                listener.Stop();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            channel = "#" + textBox1.Text;

            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = AUTH_URL,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally { await StartHttpListenerAsync(); }

            FinishConnectingTwitch();
            checkBox1.Checked = true;
        }

        private void Listen()
        {
            new Thread(() =>
            {
                string? message;
                while ((message = reader?.ReadLine()?.Trim()) != null)
                {
                    int messageStartIndex = message.IndexOf(" :");
                    if (messageStartIndex != -1)
                    {
                        var actualMessage = message.Substring(messageStartIndex + 2).Trim();
                        if (actualMessage.Equals("!randomize", StringComparison.OrdinalIgnoreCase))
                        {
                            var usernameEndIndex = message.IndexOf("!");
                            if (usernameEndIndex != -1)
                            {
                                var chatter = message.Substring(1, usernameEndIndex - 1);
                                Random random = new Random();

                                int pokeIndex = random.Next(Dictionary.Pokemon.Count);
                                Pokemon p = Dictionary.Pokemon[pokeIndex];
                                int moveAIndex = random.Next(p.MoveA.Count);
                                int moveBIndex = random.Next(p.MoveB.Count);

                                SendChatMessage($"[UNITE Randomizer] {chatter} rolled: {p.Name} - {p.MoveA[moveAIndex]} / {p.MoveB[moveBIndex]}");
                            }
                        }
                    }
                }
            }).Start();
        }

        private void SendChatMessage(string message)
        {
            writer?.WriteLine($"PRIVMSG {channel} :{message}");
        }

        private void FinishConnectingTwitch()
        {
            try
            {
                client = new TcpClient("irc.chat.twitch.tv", 6697);
                var sslStream = new SslStream(client.GetStream());
                sslStream.AuthenticateAsClient("irc.chat.twitch.tv");
                reader = new StreamReader(sslStream);
                writer = new StreamWriter(sslStream) { NewLine = "\r\n", AutoFlush = true };
                writer.WriteLine($"PASS {oauth}");
                writer.WriteLine($"NICK {username}");
                writer.WriteLine($"JOIN {channel}");

                Listen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                Form1.CHANNEL = username;
                Form1.CONNECTED = true;
                UpdateToolStripLabel?.Invoke(this, $"Connected to: {username}");
            }
        }

        private void ConnectTwitch_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Form1.CHANNEL)) { textBox1.Text = Form1.CHANNEL.ToString(); }
            if (Form1.CONNECTED) { checkBox1.Checked = true; }
        }
    }
}
