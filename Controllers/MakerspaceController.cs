using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MakersOfDenmark.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace MakersOfDenmark.Controllers
{
    public class MakerspaceController : Controller
    {
        HttpClientHandler _clientHandler = new HttpClientHandler();
        Makerspace _oMakerspace = new Makerspace();
        List<Makerspace> _oMakerspaces = new List<Makerspace>();

        public MakerspaceController()
        {
            _clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        }

        //
        // GET ALL MAKERSPACES FROM API
        [HttpGet]
        public async Task<List<Makerspace>> GetAllMakerspaces()
        {
            _oMakerspaces = new List<Makerspace>();

            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("https://fablabsandbox.azurewebsites.net/api/Makerspaces"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _oMakerspaces = JsonConvert.DeserializeObject<List<Makerspace>>(apiResponse);
                }
            }

            for (int i = 0; i < _oMakerspaces.Count; i++)
            {
                //_oMakerspaces[i].makerSpaceName = _oMakerspaces[i].makerSpaceName.ToLower();
            }

            return _oMakerspaces;
        }

        //
        // GET SINGLE MAKERSPACE FROM API
        // (VIRKER IKKE UDEN AUTH VIA JWT-TOKEN)
        /* [HttpGet]
        public async Task<Makerspace> GetById(string makerSpaceId)
        {
            _oMakerspace = new Makerspace();

            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("https://fablabsandbox.azurewebsites.net/api/Makerspaces" + makerSpaceId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _oMakerspace = JsonConvert.DeserializeObject<Makerspace>(apiResponse);
                }
            }

            return _oMakerspace;
        } */

        // 
        // GET: /Makerspace/
        public IActionResult Index()
        {
            try
            {
                var response = GetAllMakerspaces().Result;
                return View(response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // 
        // GET: /Makerspace/Name/ 
        public IActionResult Id(string id)
        {
            try
            {
                var response = GetAllMakerspaces().Result;
                var makerspaceIndex = response.FindIndex(x => x.makerSpaceName.ToLower() == id);
                return View(response[makerspaceIndex]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }
    }
}