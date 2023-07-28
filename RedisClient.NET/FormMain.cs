using Newtonsoft.Json;
using StackExchange.Redis;

namespace RedisClient.NET
{
    public partial class FormMain : Form
    {
        private ConnectionMultiplexer redis;
        private bool isConnected = false;
        private bool showJSON = true;

        public FormMain()
        {
            InitializeComponent();
        }

        private string RedisServer => $"{textServer.Text.Trim()}:{textPort.Text.Trim()}";

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                redis.Close();
                redis.Dispose();
                isConnected = false;
                dataGridViewKeys.Enabled = false;
                buttonRefresh.Enabled = false;
                textServer.ReadOnly = false;
                textPort.ReadOnly = false;
                buttonConnect.Text = "Conectar";
                dataGridViewKeys.Rows.Clear();
                textBoxKeySelected.Text = string.Empty;
                textResult.Text = string.Empty;
                buttonRemoveKeys.Enabled = false;
                buttonNewKey.Enabled = false;
                this.Text = $"RedisClient.NET [Desconectado]";
            }
            else
            {
                redis = ConnectionMultiplexer.Connect(new ConfigurationOptions { EndPoints = { RedisServer } });
                this.Text = $"RedisClient.NET [Conectado a {RedisServer}]";
                isConnected = true;
                dataGridViewKeys.Enabled = true;
                buttonRefresh.Enabled = true;
                textServer.ReadOnly = true;
                textPort.ReadOnly = true;
                buttonRemoveKeys.Enabled = true;
                buttonNewKey.Enabled = true;
                buttonConnect.Text = "Desconectar";
                GetRedisKeys();
            }
            //var db = redis.GetDatabase();
            //await db.StringSetAsync($"Prueba{DateTime.Now:yyyyMMddHHmm} XXXXXXXXXXXXXXXXXXXYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", $"Contenido Prueba {DateTime.Now:yyyyMMddHHmm}");           
        }

        private void GetRedisKeys()
        {
            dataGridViewKeys.Rows.Clear();
            var server = redis.GetServer(RedisServer);
            var keys = server.Keys(pattern: "*");
            foreach (var key in keys)
            {
                dataGridViewKeys.Rows.Add(key.ToString());
            }
            textBoxKeySelected.Text = string.Empty;
            textResult.Text = string.Empty;
            ShowSelectedRow();
        }

        private void ButtonRemoveKeys_Click(object sender, EventArgs e)
        {
            var rows = dataGridViewKeys.SelectedRows;
            if (rows.Count == 0)
            {
                return;
            }
            var r = MessageBox.Show($"¿Desea eliminar las {rows.Count} claves seleccionadas?", "Eliminar claves", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (r != DialogResult.OK)
            {
                return;
            }
            var db = redis.GetDatabase();
            foreach (DataGridViewRow row in rows)
            {
                db.KeyDelete(row.Cells[0].Value.ToString().Trim());
            }
            GetRedisKeys();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            GetRedisKeys();
        }

        private void ShowSelectedRow()
        {
            var rows = dataGridViewKeys.SelectedRows;
            if (rows.Count == 0)
            {
                textBoxKeySelected.Text = string.Empty;
                textResult.Text = string.Empty;
                return;
            }
            var key = rows[0].Cells[0].Value.ToString().Trim();
            var db = redis.GetDatabase();
            textBoxKeySelected.Text = key;
            var content = db.StringGet(key).ToString();
            if (content != string.Empty)
            {
                if (showJSON)
                {
                    try
                    {
                        var data = JsonConvert.DeserializeObject(content);
                        content = JsonConvert.SerializeObject(data, Formatting.Indented);
                    }
                    catch { }
                }
                textResult.Text = content;
            }
        }

        private void ButtonNewKey_Click(object sender, EventArgs e)
        {
            using var newFormEntry = new FormNewEntry();
            var result = newFormEntry.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var db = redis.GetDatabase();
                db.StringSet(newFormEntry.textBoxKey.Text.Trim(), newFormEntry.textBoxContent.Text.Trim());
                GetRedisKeys();
            }
        }

        private void DataGridViewKeys_SelectionChanged(object sender, EventArgs e)
        {
            ShowSelectedRow();
        }

        private void RadioButtonJSON_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonJSON.Checked)
            {
                showJSON = true;
                radioButtonText.Checked = false;
            }
            ShowSelectedRow();
        }

        private void RadioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonText.Checked)
            {
                showJSON = false;
                radioButtonJSON.Checked = false;
            }
            ShowSelectedRow();
        }
    }
}