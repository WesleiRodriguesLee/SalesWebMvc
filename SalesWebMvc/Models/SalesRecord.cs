using SalesWebMvc.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status{ get; set; }

        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            ID = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
