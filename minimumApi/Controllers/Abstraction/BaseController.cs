using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace minimumApi.Controllers.Abstraction
{
    public class BaseController : Controller
    {
        protected IMapper _mapper;
        protected ILogger _logger;
        public BaseController(IMapper mapper, ILoggerFactory loggerFactory)
        {
            this._mapper = mapper;
            this._logger = loggerFactory.CreateLogger(this.GetType());
        }
    }
}
