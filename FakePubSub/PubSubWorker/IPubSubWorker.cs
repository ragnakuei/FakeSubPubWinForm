namespace FakePubSub.PubSubWorker
{
    internal interface IPubSubWorker<T, F>
    {
        void RegisterForm(T form);

        bool UnRegisterForm(T form);

        void Change(T form, F fieldValue);
    }
}
