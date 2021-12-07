using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bor.DataAccess.Core.Models
{
    [Table("User")]
    public class UserRto
    {
        #region главные поля
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required] public string PhoneNumberPrefix { get; set; }
        [Required] public string PhoneNumber { get; set; }
        [Required, MinLength(7)] public string Password { get; set; }
        public string ImageUrl { get; set; }
        #endregion

        #region внешние ключи
        public List<VirtualExpenseRto> VirtualExpenses { get; set; }
        public List<RejectExpenseRto> RejectExpenses { get; set; }
        public List<AcceptExpenseRto> AcceptExpenses { get; set; }
        #endregion
    }
}
