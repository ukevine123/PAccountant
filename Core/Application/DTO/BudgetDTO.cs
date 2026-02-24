namespace Application.DTO.Budget
{
      public class BudgetCreateDTO
      {
        public string Name { get; set; }
        public int CategoryId { get; set; }
         public decimal MonthlyLimit { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }

     }
        public class BudgetUpdateDTO
        {
            public string Name { get; set; }
            public int CategoryId { get; set; }
            public decimal MonthlyLimit { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Status { get; set; }
    
         }
}
