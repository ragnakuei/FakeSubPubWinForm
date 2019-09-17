using System.Collections.Generic;
using System.Linq;

namespace FakePubSub.PubSubWorker
{
    internal class PubSubWorkerName : IPubSubWorker<IChangeNameField, string>
    {
        private readonly List<IChangeNameField> _forms;

        public PubSubWorkerName()
        {
            _forms = new List<IChangeNameField>();
        }

        public void RegisterForm(IChangeNameField form)
        {
            _forms.Add(form);
        }

        public bool UnRegisterForm(IChangeNameField form)
        {
            return _forms.Remove(form);
        }

        public void Change(IChangeNameField form,string value)
        {
            var forms = _forms.Where(f => f != form);
            foreach (var changeNameField in forms)
            {
                changeNameField.ChangeField(value);
            }
        }
    }
}