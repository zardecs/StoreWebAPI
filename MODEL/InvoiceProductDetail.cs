﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MODEL
{
    public class InvoiceProductDetail
    {
        public int InvoiceProductDetailId { get; set; }
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }

    }
}