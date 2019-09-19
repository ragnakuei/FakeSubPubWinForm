using System.Collections.Generic;

namespace FakePubSub.PubSubWorker
{
    internal abstract class PubSubWorker<T, F>
    {
        protected readonly List<T> _forms;

        public PubSubWorker()
        {
            _forms = new List<T>();
        }

        public void Subscribe(T form)
        {
            _forms.Add(form);
        }

        public bool UnSubscribe(T form)
        {
            return _forms.Remove(form);
        }

        public abstract void Publish(T form, F value);
    }
}
