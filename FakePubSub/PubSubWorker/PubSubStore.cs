using System.Collections.Generic;

namespace FakePubSub.PubSubWorker
{
    public class PubSubStore
    {
        private readonly Dictionary<PubSubStoreField, dynamic> _workers;

        public PubSubStore()
        {
            _workers = new Dictionary<PubSubStoreField, dynamic>
                       {
                           [PubSubStoreField.Name] = new PubSubWorkerName(),
                           [PubSubStoreField.Count] = new PubSubWorkerCount()
                       };
        }

        public void Register(PubSubStoreField field, dynamic form)
        {
            _workers.GetValue(field).Register(form);
        }

        public void UnRegister(PubSubStoreField field, dynamic form)
        {
            _workers.GetValue(field).UnRegister(form);
        }

        public void Change(PubSubStoreField field, dynamic form, dynamic value)
        {
            _workers.GetValue(field).Change(form, value);
        }

        public dynamic GetWorker(PubSubStoreField field)
        {
            return _workers.GetValue(field);
        }
    }
}