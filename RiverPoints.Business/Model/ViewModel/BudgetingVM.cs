using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Budgeting.Business.Model.ViewModel
{
    public class BudgetingVM
    {
        public int Id { get; set; }
        public Nullable<int> workflowId { get; set; }
        public decimal salaries { get; set; }
        public decimal rent { get; set; }
        public Nullable<int> b_elements1Id { get; set; }
        public Nullable<int> b_elements2Id { get; set; }
        public Nullable<int> b_elements3Id { get; set; }
        public string files { get; set; }
        public HttpPostedFileBase fileBase { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string comments { get; set; }
        public string version { get; set; }
        public Nullable<decimal> b_elements1_val { get; set; }
        public Nullable<decimal> b_elements2_val { get; set; }
        public Nullable<decimal> b_elements3_val { get; set; }
    }
}
