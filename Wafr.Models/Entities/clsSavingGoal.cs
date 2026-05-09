using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wafr.Models.Entities
{
    public class clsSavingGoal
    {
        public int SavingGoalID { get; set; }

        public int UserID { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Emoji { get; set; } = string.Empty;

        public decimal TargetAmount { get; set; }

        public decimal CurrentAmount { get; set; }

        public string Status { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public DateTime? ClosedAt { get; set; }
    }
}
