using AutoMapper;
using BoozewasherApp_Web.Models;
using BoozewasherApp_Web.Models.ContextModel;
using BoozewasherApp_Web.Models.Dtos;
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

        //GET /API/Branches/1
        public IHttpActionResult GetBranch(int id)
        {
            var branch = _context.Branches.SingleOrDefault(b => b.Id == id);

            if (branch == null)
                return NotFound();

            return Ok(Mapper.Map<Branch, BranchDto>(branch));
        }

        //POST /API/Branches
        [HttpPost]
        public IHttpActionResult CreateBranch(BranchDto branchDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var branch = Mapper.Map<BranchDto, Branch>(branchDto);
            _context.Branches.Add(branch);
            _context.SaveChanges();

            branchDto.Id = branch.Id;

            return Created(new Uri(Request.RequestUri + "/" + branch.Id), branchDto);
        }

        //PUT /API/Branches/1
        [HttpPut]
        public void UpdateBranch(BranchDto branchDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var branchInDB = _context.Branches.Single(b => b.Id == branchDto.Id);

            if (branchInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(branchDto, branchInDB);

            _context.SaveChanges();

        }

        //DELETE /API/Branches/1
        [HttpDelete]
        public void DeleteBranch(int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var branchInDB = _context.Branches.SingleOrDefault(b => b.Id == id);

            if (branchInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Branches.Remove(branchInDB);
            _context.SaveChanges();
        }
    }
}