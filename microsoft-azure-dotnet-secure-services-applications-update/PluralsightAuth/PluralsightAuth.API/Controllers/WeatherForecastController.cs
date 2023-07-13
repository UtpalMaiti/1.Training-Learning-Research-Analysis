using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PluralsightAuth.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            // call the second api to get the actual weather forecasts

            var httpClient = _httpClientFactory.CreateClient();

            var currentAccessToken = await HttpContext.GetTokenAsync("access_token");
            var responseFromTokenEndpoint = await httpClient.RequestTokenAsync(
                new TokenRequest
                {
                    Address = 
                        "https://login.microsoftonline.com/32f61fed-c327-4305-b36d-3bc644e00a1b/oauth2/v2.0/token",
                    GrantType = "urn:ietf:params:oauth:grant-type:jwt-bearer",
                    ClientId = "e2bf5851-7bbc-49eb-9dd7-8fd813d83d40",
                    ClientSecret = "6XA7cCT6sPTps..VoB8Y3_r124sq_2~IbG",
                    Parameters =
                    {
                        { "assertion", currentAccessToken },
                        { "scope", "api://e7cd1dee-1db0-4faa-8fa0-1df91f42503a/FullAccess"},
                        { "requested_token_use", "on_behalf_of"}
                    }
                });
 
            var request = new HttpRequestMessage(
                HttpMethod.Get,
                "https://localhost:44378/weatherforecast");
            request.Headers.Authorization = 
                new AuthenticationHeaderValue("Bearer", responseFromTokenEndpoint.AccessToken);

            var response = await httpClient.SendAsync(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                // error happened
                throw new Exception(response.ReasonPhrase);
            }

            return await JsonSerializer.DeserializeAsync<IEnumerable<WeatherForecast>>(
                await response.Content.ReadAsStreamAsync());
        }
    }
}
