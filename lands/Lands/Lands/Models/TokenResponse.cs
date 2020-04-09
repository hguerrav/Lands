

namespace Lands.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;

    public class TokenResponse
    {
        #region Properties
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }
        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }
        [JsonProperty(PropertyName = "expires_in")]
        public string ExpiresIn { get; set; }
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        [JsonProperty(PropertyName = "issued")]
        public string Issued { get; set; }
        [JsonProperty(PropertyName = "expies")]
        public string Expies { get; set; }
        [JsonProperty(PropertyName = "errror_description")]
        public string ErrrorDescription { get; set; }


        #endregion
    }
}
