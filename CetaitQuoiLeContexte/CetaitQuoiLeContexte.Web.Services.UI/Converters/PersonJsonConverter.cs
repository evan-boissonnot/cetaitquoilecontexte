using CetaitQuoiLeContexte.Core.Data;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetaitQuoiLeContexte.Web.Services.UI.Converters
{
    public class PersonJsonConverter : JsonConverter
    {
        #region Public methods
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IPerson);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize(reader, typeof(Person));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
