using Microsoft.AspNetCore.DataProtection;
using Newtonsoft.Json;
using System.Net;
namespace DECK_OF_CARDS_LAB.Models
{
    public class DOCDAL
    {
        public static DOC GetDOC() //Adjust here
        {
            //adjust
            //setup
            string key = Hidden.Key;
            string url = $"https://deckofcardsapi.com/api/deck/{key}/draw/?count=5";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust
            //Convert to C#
            DOC result = JsonConvert.DeserializeObject<DOC>(JSON);
            return result;
        }

        public static void GetShuffle() //Adjust here
        {
            //adjust
            //setup
            string key = Hidden.Key;
            string url = $"https://deckofcardsapi.com/api/deck/tx1u4444e596/shuffle/";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust
            //Convert to C#
            DOC result = JsonConvert.DeserializeObject<DOC>(JSON);

        }
    }
}

