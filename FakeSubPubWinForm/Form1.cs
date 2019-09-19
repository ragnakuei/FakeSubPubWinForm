using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakePubSub;
using FakePubSub.PubSubWorker;

namespace FakeSubPubWinForm
{
    public partial class Form1 : Form, IPublishFieldName
    {
        private readonly PubSubStore _pubSubStore;

        public Form1(PubSubStore pubSubStore)
        {
            InitializeComponent();

            _pubSubStore = pubSubStore;

            _pubSubStore.Subscribe(PubSubStoreField.Name, this);
        }

        public void PublishName(string value)
        {
            tbxName.Text = value as string;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            var value = (sender as TextBox)?.Text ?? string.Empty;
            _pubSubStore.Publish(PubSubStoreField.Name, this, value);
        }

        private void BtnOpenForm2_Click(object sender, EventArgs e)
        {
            new Form2(_pubSubStore).Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _pubSubStore.UnSubscribe(PubSubStoreField.Name, this);
        }

        private void BtnOpenForm3_Click(object sender, EventArgs e)
        {
            new Form3(_pubSubStore).Show();
        }
    }
}
