using System.Runtime.Serialization;

namespace JanuaryBatchAutoTest.Enums
{
    public class browserTypes
    {
        public enum browserType
        {
            Chrome,
            Edge,
            Firefox,
            Opera
        }

        public enum locatorType
        {
            Id,
            Name,
            Xpath,
            CssSelector
        }

        public enum labelsType
        {
            [EnumMember(Value = "userName")]
            userName,
            [EnumMember(Value = "password")]
            password
        }

        public string GetIdType()
        {
            return nameof(locatorType.Id);
        }
    }
}
