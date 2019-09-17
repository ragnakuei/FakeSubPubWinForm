using System.Collections.Generic;
using System.Linq;

namespace FakePubSub.PubSubWorker
{
    internal class PubSubWorkerCount : IPubSubWorker<IChangeCountField, decimal>
    {
        private readonly List<IChangeCountField> _forms;

        public PubSubWorkerCount()
        {
            _forms = new List<IChangeCountField>();
        }

        public void RegisterForm(IChangeCountField form)
        {
            _forms.Add(form);
        }

        public bool UnRegisterForm(IChangeCountField form)
        {
            return _forms.Remove(form);
        }

        public void Change(IChangeCountField form, decimal value)
        {
            var forms = _forms.Where(f => f != form);
            foreach (var changedCountField in forms)
            {
                changedCountField.ChangeField(value);
            }
        }
    }
}
