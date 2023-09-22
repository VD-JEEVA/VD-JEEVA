using Microsoft.VisualBasic;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectivity
{
    class LedgerModel
    {
        public int LedgerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public string? BookName { get; set; }
        public string? GenreName { get; set; }
        public DateTime BookOutDate { get; set; }
        public LedgerModel(int LedgerId, string? CustomerName, string? CustomerPhone, string? BookName, string? GenreName, DateTime BookOutDate)
        {
            this.LedgerId = LedgerId;
            this.CustomerName = CustomerName;
            this.CustomerPhone = CustomerPhone;
            this.BookName = BookName;
            this.GenreName = GenreName;
            this.BookOutDate = BookOutDate;
        }
    }
}
