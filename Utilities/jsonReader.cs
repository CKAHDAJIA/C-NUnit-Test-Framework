using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharpSeleniumFramework.utilities
{
    public class jsonReader
    {
        private String _siteConfigurationUrl;
        public jsonReader(String siteConfigurationUrl)
        {
            this._siteConfigurationUrl = siteConfigurationUrl;
        }

        public string extractData(String tokenName)
        {
            String myJsonString = File.ReadAllText(_siteConfigurationUrl);
            var jsonObject = JToken.Parse(myJsonString);
            return jsonObject.SelectToken(tokenName).Value<String>();
        }

        public string[] extractDataArray(String tokenName) // we use this for the products which we seletct to handle strings from json
        {
            String myJsonString = File.ReadAllText(_siteConfigurationUrl);
            var jsonObject = JToken.Parse(myJsonString);
            List<String> productsList = jsonObject.SelectTokens(tokenName).Values<String>().ToList();
            return productsList.ToArray();
        }


    }


}