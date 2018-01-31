using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Sample.Models;

namespace Sample.Controllers
{
    [Route("api/settings")]
    public class SettingsController : Controller
    {
        IConfiguration configuration;
        public SettingsController(IConfiguration config)
        {
            configuration = config;
        }
        [HttpGet]
        public IActionResult Get(bool withJsonProperties)
        {
            var settings = new Settings();
            var settingsDirect = new SettingsDirect();
            if (withJsonProperties)
            {
                configuration.GetSection("settings").Bind(settings);
                return Ok(settings);
            }
            else
            {
                configuration.GetSection("settings").Bind(settingsDirect);
                return Ok(settingsDirect);
            }            
        }
    }
}