using DatingAPI.Data;
using DatingAPI.Entities;
using System.Collections;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseAPIController : ControllerBase
    {
    }
}
