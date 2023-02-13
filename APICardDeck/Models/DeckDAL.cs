using System;
using Newtonsoft.Json;
using System.Net;

namespace APICardDeck.Models
{
    public class DeckDAL
    {
        public static DeckModel GetDeck()  //THIS IS A PLUG AND PLAY METHOD
        {
            //setup

            string url = "https://deckofcardsapi.com/api/deck/new/draw/?count=5";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();


            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Convert to C#
            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(JSON);
            return result;
        }
    }
}





