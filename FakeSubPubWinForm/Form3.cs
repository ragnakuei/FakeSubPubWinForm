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
    public partial class Form3 : Form, IChangeCountField
    {
        private readonly PubSubStore _pubSubStore;

        public Form3(PubSubStore pubSubStore)
        {
            InitializeComponent();

            _pubSubStore = pubSubStore;

            _pubSubStore.Register(PubSubStoreField.Count, this);
        }

        public void ChangeField(decimal value)
        {
            nudCount.Value = value;
        }

        private void NudCount_ValueChanged(object sender, EventArgs e)
        {
            var value = (sender as NumericUpDown)?.Value ?? 0m;
            _pubSubStore.Change(PubSubStoreField.Count, this, value);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            _pubSubStore.UnRegister(PubSubStoreField.Count, this);
        }
    }
}
