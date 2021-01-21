using BoozewasherApp_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BoozewasherApp_Web.Controllers.API
{
    public class BranchesController : ApiController
    {
        private ApplicationDbContext _context;

        public BranchesController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /API/Branches    
        public IHttpActionResult GetBranches()
        {
            var branches = _context.Branches;

            return Ok(branches);
        }
    }
}