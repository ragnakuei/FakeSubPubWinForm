using System.Collections.Generic;
using System.Linq;

namespace FakePubSub.PubSubWorker
{
    internal class PubSubWorkerCount : PubSubWorker<IPublishFieldCount, decimal>
    {
        public override void Publish(IPublishFieldCount form, decimal value)
        {
            var forms = _forms.Where(f => f != form);
            foreach (var changedCountField in forms)
            {
                changedCountField.PublishCount(value);
            }
        }
    }
}
