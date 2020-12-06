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
    public class TransactionsController : ApiController
    {
        private ApplicationDbContext _context;

        public TransactionsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //GET /API/Transactions
        public IList<Transaction> GetTransactions()
        {
            return _context.Transactions.Include("Service")
                                        .Include("Vehicle")
                                        .ToList();
        }

        //GET /API/Transactions
        public IList<Transaction> GetTransactionsByDateRange(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            return _context.Transactions.Include("Service")
                                        .Include("Vehicle")
                                        .Where(a => a.DateTime.Date.CompareTo(dateTimeFrom.Date) >= 0 && a.DateTime.Date.CompareTo(dateTimeTo.Date) <= 0)
                                        .ToList();
        }

        public IList<Transaction> GetTransactionsByDate(DateTime dateTime)
        {
            return _context.Transactions.Include("Service")
                                        .Include("Vehicle")
                                        .Where(a => a.DateTime.Date == dateTime.Date)
                                        .ToList();
        }

        //GET /API/Transactions/1
        public IHttpActionResult GetTransaction(int id)
        {
            var transaction = _context.Transactions.SingleOrDefault(v => v.Id == id);

            if (transaction == null)
                return NotFound();

            return Ok(Mapper.Map<Transaction, TransactionDto>(transaction));
        }

        //POST /API/Transactions
        [HttpPost]
        public IHttpActionResult CreateTransactions(Transaction transaction)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Transactions.Add(transaction);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + transaction.Id), transaction);
        }

        //PUT /API/Transaction/1
        [HttpPut]
        public void UpdateTransaction(TransactionDto transactionDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var transactionInDb = _context.Transactions.Single(v => v.Id == transactionDto.Id);

            if (transactionInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(transactionDto, transactionInDb);

            _context.SaveChanges();

        }

        //DELETE /API/Transaction/1
        [HttpDelete]
        public void DeleteTransaction(int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var transactionInDb = _context.Transactions.SingleOrDefault(v => v.Id == id);

            if (transactionInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Transactions.Remove(transactionInDb);
            _context.SaveChanges();
        }
    }
}
