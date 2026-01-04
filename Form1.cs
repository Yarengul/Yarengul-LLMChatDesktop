using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LLMChatDesktop
{
    public partial class Form1 : Form
    {
        // 1. ADIM: Groq API anahtarını buraya tırnakların içine yapıştır
        private readonly string apiKey = "";

        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            // Enter tuşuna basınca btnSend_Click çalışır
            this.AcceptButton = btnSend;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userPrompt = txtUserInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(userPrompt))
                return;

            // Kullanıcı mesajını ekrana yazdır
            AppendChat("Siz: ", userPrompt);
            txtUserInput.Clear();

            // Yanıt gelene kadar butonu pasif yap
            btnSend.Enabled = false;
            btnSend.Text = "...";

            try
            {
                string aiResponse = await GetGroqResponse(userPrompt);
                AppendChat("AI: ", aiResponse);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSend.Enabled = true;
                btnSend.Text = "Gönder";
            }
        }

        private async Task<string> GetGroqResponse(string prompt)
        {
            string url = "https://api.groq.com/openai/v1/chat/completions";

            // En stabil JSON yapısı
            var requestData = new
            {
                model = "llama-3.3-70b-versatile",
                messages = new[]
                {
                    new { role = "user", content = prompt }
                },
                temperature = 0.7
            };

            string jsonPayload = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            // Header ayarlarını temizleyip yeniden kuralım
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey.Trim());

            HttpResponseMessage response = await client.PostAsync(url, content);
            string responseJson = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                // JSON içinden cevabı çekme
                dynamic result = JsonConvert.DeserializeObject(responseJson);
                return result.choices[0].message.content;
            }
            else
            {
                // Hata durumunda API'den gelen mesajı göster
                return $"Hata Detayı: {response.StatusCode} - {responseJson}";
            }
        }

        private void AppendChat(string role, string message)
        {
            // Rol (Siz/AI) kısmını kalın yapalım
            rtbChatHistory.SelectionFont = new System.Drawing.Font(rtbChatHistory.Font, System.Drawing.FontStyle.Bold);
            rtbChatHistory.AppendText(role);

            // Mesaj kısmını normal yapalım
            rtbChatHistory.SelectionFont = new System.Drawing.Font(rtbChatHistory.Font, System.Drawing.FontStyle.Regular);
            rtbChatHistory.AppendText(message + Environment.NewLine + Environment.NewLine);

            // Otomatik aşağı kaydır
            rtbChatHistory.SelectionStart = rtbChatHistory.Text.Length;
            rtbChatHistory.ScrollToCaret();
        }
    }
}