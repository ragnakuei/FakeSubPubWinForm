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
    public partial class Form3 : Form, IPublishFieldCount
    {
        private readonly PubSubStore _pubSubStore;

        public Form3(PubSubStore pubSubStore)
        {
            InitializeComponent();

            _pubSubStore = pubSubStore;

            _pubSubStore.Subscribe(PubSubStoreField.Count, this);
        }

        public void PublishCount(decimal value)
        {
            nudCount.Value = value;
        }

        private void NudCount_ValueChanged(object sender, EventArgs e)
        {
            var value = (sender as NumericUpDown)?.Value ?? 0m;
            _pubSubStore.Publish(PubSubStoreField.Count, this, value);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            _pubSubStore.UnSubscribe(PubSubStoreField.Count, this);
        }
    }
}
