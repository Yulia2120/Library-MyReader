using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.IO;

namespace Library_MyReader
{
    public partial class TextForm : Form
    {
        private string pathText = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "text");
        static SpeechSynthesizer synth;
        public TextForm()
        {
            InitializeComponent();
            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.SpeakCompleted += Synth_SpeakCompleted;
        }
        private void Synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            MessageBox.Show("Speech end", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void butSpeech_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Equals(String.Empty))
            {
                synth.Speak(textBox.Text);
            }
        }
        public void TextFromFolder()
        {
            OpenFileDialog openFD = new OpenFileDialog();
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                openFD.Filter = "*.txt|*.txt|All files(*.*)|*.*";
                FileStream file = new FileStream(openFD.FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file, Encoding.Default);
                textBox.Text = reader.ReadToEnd();
                reader.Close();
                pathText = openFD.FileName;

            }
        }

       
       
    }
}
