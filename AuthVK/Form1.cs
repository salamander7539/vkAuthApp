using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;


namespace AuthVK
{
    public partial class Form1 : Form
    {
        string token, id;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveMyData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenMyData();
            Authoriz();
        }

        void SaveMyData()
        {
            if (!File.Exists(@"C:\Users\Public\Documents\LoadVKData.txt"))
            {
                string[] VkData = new string[]
                {
                    log_textBox.Text,
                    pass_textBox.Text
                };
                File.Create(@"C:\Users\Public\Documents\LoadVKData.txt").Close();
                File.WriteAllLines(@"C:\Users\Public\Documents\LoadVKData.txt", VkData);
            }
            else
            {
                File.Delete("LoadVKData.txt");
                string[] VkData = new string[]
                {
                    log_textBox.Text,
                    pass_textBox.Text
                };
                File.Create(@"C:\Users\Public\Documents\LoadVKData.txt").Close();
                File.WriteAllLines(@"C:\Users\Public\Documents\LoadVKData.txt", VkData);
            }
        }

        void OpenMyData()
        {
            if (File.Exists(@"C:\Users\Public\Documents\LoadVKData.txt"))
            {
                string[] aut_data = File.ReadAllLines(@"C:\Users\Public\Documents\LoadVKData.txt");
                log_textBox.Text = aut_data[0];
                pass_textBox.Text = aut_data[1];
                
            }
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            Authoriz();
        }

        //Авторизация
        void Authoriz()
        {
            try
            {
                var ent_data = new HttpRequest();
                string response = ent_data.Get("https://oauth.vk.com/token?grant_type=password&client_id=2274003&client_secret=hHbZxrka2uZ6jB1inYsH&username=" + log_textBox.Text + "&password=" + pass_textBox.Text).ToString();
                dynamic json = JObject.Parse(response);
                token = json.access_token;
                id = json.user_id;
                if (id.Count() > 1)
                {
                    stastus_label.Text = stastus_label.Text + " ОK!";
                }
            }
            catch
            {
                stastus_label.Text = stastus_label.Text + " Enter your Login and Password";
            }
        }
        //Получить информацию
        private void info_button_Click(object sender, EventArgs e)
        {
            var qwer = new HttpRequest();
            string response = qwer.Get("https://api.vk.com/method/account.getProfileInfo?v=5.52&access_token=" + token).ToString();
            dynamic json = JObject.Parse(response);
            string f_name = json.response.first_name;
            string l_name = json.response.last_name;
            stastus_label.Text += Environment.NewLine + f_name + " " + l_name;
            GetFriends();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void GetFriends()
        {
            listBox1.Items.Clear();
            var qwer = new HttpRequest();
            string response = qwer.Get("https://api.vk.com/method/friends.search?v=5.52&count=5&access_token=" + token).ToString();
            dynamic json = JObject.Parse(response);
            int count = json.response.count;
            string[] fname = new string[count];
            string[] lname = new string[count];
            for (int i = 0; i < 5; i++)
            {
                fname[i] = json["response"]["items"][i]["first_name"];
                lname[i] = json["response"]["items"][i]["last_name"];
                listBox1.Items.Add(fname[i] + " " + lname[i] + Environment.NewLine);
            }
        }
    }
}
