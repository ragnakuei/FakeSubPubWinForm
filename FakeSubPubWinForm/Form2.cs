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
    public partial class Form2 : Form, IPublishFieldName, IPublishFieldCount
    {
        private readonly PubSubStore _pubSubStore;

        public Form2(PubSubStore pubSubStore)
        {
            InitializeComponent();

            _pubSubStore = pubSubStore;

            _pubSubStore.Subscribe(PubSubStoreField.Name, this);
            _pubSubStore.Subscribe(PubSubStoreField.Count, this);
        }

        public void Publis(string value)
        {
            tbxName.Text = value;
        }

        public void Publish(decimal value)
        {
            nudCount.Value = value;
        }

        private void TbxName_TextChanged(object sender, EventArgs e)
        {
            var value = (sender as TextBox)?.Text ?? string.Empty;
            _pubSubStore.Publish(PubSubStoreField.Name, this, value);
        }

        private void NudCount_ValueChanged(object sender, EventArgs e)
        {
            var value = (sender as NumericUpDown)?.Value ?? 0m;
            _pubSubStore.Publish(PubSubStoreField.Count, this, value);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _pubSubStore.UnSubscribe(PubSubStoreField.Name, this);
            _pubSubStore.UnSubscribe(PubSubStoreField.Count, this);
        }
    }
}