﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus SaleStatuss { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus saleStatuss, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            SaleStatuss = saleStatuss;
            Seller = seller;
        }
    }
}
