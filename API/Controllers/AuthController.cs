using Contracts.Auth;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Create instance of <see cref="AuthController"/> class.
        /// </summary>
        /// <param name="mediator">The mediator to mangement the request and response.</param>
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Register(AuthRegisterRequest request)
        {

        }

        public async Task<IActionResult> Login(AuthLoginRequest request)
        {

        }

    }
}
