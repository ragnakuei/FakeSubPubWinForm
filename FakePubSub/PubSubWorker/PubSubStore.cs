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

        public void Subscribe(PubSubStoreField field, dynamic form)
        {
            _workers.GetValue(field)?.Subscribe(form);
        }

        public void UnSubscribe(PubSubStoreField field, dynamic form)
        {
            _workers.GetValue(field)?.UnSubscribe(form);
        }

        public void Publish(PubSubStoreField field, dynamic form, dynamic value)
        {
            _workers.GetValue(field)?.Publish(form, value);
        }
    }
}