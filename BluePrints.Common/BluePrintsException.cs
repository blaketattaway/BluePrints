namespace BluePrints.Common
{
    public class BluePrintsException : Exception
    {
        public BluePrintsException(string message, string additionalData) : base(message)
        {
            AdditionalData = additionalData;
        }

        public string AdditionalData { get; set; }
    }
}