using knights.Services;
using Microsoft.AspNetCore.Mvc;

namespace knights.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KnightsController : ControllerBase
    {
        private readonly KnightsService _cs;

    }
}