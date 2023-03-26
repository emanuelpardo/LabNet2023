using MVC.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class RickandMortyAPIController : Controller
    {
        // GET: RickandMortyAPI
        public ActionResult Index()
        {
            const string results = "results";
            List<RickAndMortyCharacterViewModel> Lista_Personajes = new List<RickAndMortyCharacterViewModel>();
            try
            {
                string url = "https://rickandmortyapi.com/api/character";
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                HttpClient _httpClient = new HttpClient();
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                
                HttpResponseMessage response = _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string content = response.Content.ReadAsStringAsync().Result;
                    if (!string.IsNullOrEmpty(content))
                    {
                        JObject jObject = JObject.Parse(content);
                        JToken jt = jObject.GetValue(results);
                        Lista_Personajes = JsonConvert.DeserializeObject<List<RickAndMortyCharacterViewModel>>(jt.ToString());
                    }
                }
            }
            catch (Exception)
            {
                this.Volver();
            }

            return View(Lista_Personajes);
        }

        public ActionResult Volver()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}