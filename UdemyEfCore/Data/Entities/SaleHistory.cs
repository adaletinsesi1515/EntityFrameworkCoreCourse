﻿namespace UdemyEfCore.Data.Entities
{
    public class SaleHistory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        public Product product { get; set; }
        public int Amount { get; set; }
    }
}
