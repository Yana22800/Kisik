using Bor.DataAccess.Core.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bor.DataAccess.Core.Models
{
    [Table("AcceptExpense")]
     public class AcceptExpenseRto
    {
        [Key] public  int Id { get; set; }
        public int? UserId { get; set; }
        public UserRto User { get; set; }
        public string WhereSpend { get; set; }
        public float Cost { get; set; }
        public CostCurrencyRto CostCurrency { get; set; }
        public DateTimeOffset CreateDataTime { get; set; }
        public DateTimeOffset AcceptDataTime { get; set; }
    }
}
