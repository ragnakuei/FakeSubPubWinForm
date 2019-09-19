using System.Collections.Generic;
using System.Linq;

namespace FakePubSub.PubSubWorker
{
    internal class PubSubWorkerName : PubSubWorker<IPublishFieldName, string>
    {
        public override void Publish(IPublishFieldName form,string value)
        {
            var forms = _forms.Where(f => f != form);
            foreach (var changeNameField in forms)
            {
                changeNameField.PublishName(value);
            }
        }
    }
}