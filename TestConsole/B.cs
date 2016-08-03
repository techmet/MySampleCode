namespace TestConsole
{
    class B: IB
    {
        private readonly IYourType _yourType;
        public B(IYourType yourType)
        {
            _yourType = yourType;
        }

        public IYourType ReturnType()
        {
            return _yourType;
        }
    }

    interface IB
    {
        IYourType ReturnType();
    }
}