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
        public IHttpActionResult GetTransactions()
        {
            var transactionsDto = _context.Transactions.Include("Service")
                                                       .Include("Vehicle")
                                                       .Include("Branch")
                                                       .ToList();
            return Ok(transactionsDto);
        }
        //GET /API/Transactions/GetTransactionsByBranchId
        public IHttpActionResult GetTransactionsByBranchId(int id)
        {
            var transactions = _context.Transactions.Include("Service")
                                                .Include("Vehicle")
                                                .Include("Branch")
                                                .Where(a => a.BranchId == id)
                                                .ToList();

            return Ok(transactions);
        }
        [HttpPost]
        //GET /API/Transactions
        public IList<Transaction> GetTransactionsByDateRange(SummaryDateAndDateRangeDto dateAndDateRangeDto)
        {
            return _context.Transactions.Include("Service")
                                        .Include("Vehicle")
                                        .Include("Branch")
                                        .Where(a => a.DateTime.Year >= dateAndDateRangeDto.DateTimeFrom.Year &&
                                                    a.DateTime.Month >= dateAndDateRangeDto.DateTimeFrom.Month &&
                                                    a.DateTime.Day >= dateAndDateRangeDto.DateTimeFrom.Day &&
                                                    a.DateTime.Year <= dateAndDateRangeDto.DateTimeTo.Year &&
                                                    a.DateTime.Month <= dateAndDateRangeDto.DateTimeTo.Month &&
                                                    a.DateTime.Day <= dateAndDateRangeDto.DateTimeTo.Day &&
                                                    a.BranchId == dateAndDateRangeDto.BranchId)
                                        .ToList();
        }

        [HttpPost]
        public IList<Transaction> GetTransactionsByDate(SummaryDateAndDateRangeDto dateAndDateRangeDto)
        {
            return _context.Transactions.Include("Service")
                                        .Include("Vehicle")
                                        .Include("Branch")
                                        .Where(a => a.DateTime.Year == dateAndDateRangeDto.DateTime.Year &&
                                                    a.DateTime.Month == dateAndDateRangeDto.DateTime.Month &&
                                                    a.DateTime.Day == dateAndDateRangeDto.DateTime.Day &&
                                                    a.BranchId == dateAndDateRangeDto.BranchId)
                                        .ToList();
        }

        //GET /API/Transactions/1
        public IHttpActionResult GetTransaction(int id)
        {
            var transaction = _context.Transactions.Include("Service")
                                                   .Include("Vehicle")
                                                   .Include("Branch")
                                                   .SingleOrDefault(v => v.Id == id);

            if (transaction == null)
                return NotFound();

            return Ok(Mapper.Map<Transaction, TransactionDto>(transaction));
        }

        //POST /API/Transactions
        [HttpPost]
        public IHttpActionResult CreateTransaction(Transaction transaction)
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

            var transactionInDb = _context.Transactions.SingleOrDefault(v => v.Id == transactionDto.Id);

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

        //POST /API/Transactions/GetTransactionsBySearchParameter
        [HttpPost]
        public IHttpActionResult GetTransactionsBySearchParameter(SearchDto searchDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var transactions = _context.Transactions.AsEnumerable();

            switch (searchDto.SearchBy.ToUpper().Trim())
            {
                case "PLATENUMBER":
                    transactions = transactions.Where(a => a.PlateNumber.Contains(searchDto.SearchText));
                    break;

                default:
                    break;

            }
            //.ToList()
            //.Select(Mapper.Map<Item, ItemDto>);

            return Ok(transactions.ToList().Select(Mapper.Map<Transaction, TransactionDto>));
        }
    }
}
