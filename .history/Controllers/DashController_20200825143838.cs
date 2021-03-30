using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using carteiraAcoes.Entity;
using carteiraAcoes.Models;

namespace carteiraAcoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashController : ControllerBase
    {
        private readonly BancoContext _context;

        public DashController(BancoContext context)
        {
            _context = context;
        }

        // GET: api/dash
       
    }
}
