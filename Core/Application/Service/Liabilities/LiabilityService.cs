namespace Application.Service.Liabilities
{
    public class LiabilityService : ILiabilityService
    {
          private readonly ILiability _liability;
        // Constructor 
        public LiabilityService(ILiability liability)
        {
            _liability = liability;
        }
          public List<Liability> GetAllLiabilities()
        {
            List<Liability> liabilities = _liability.GetAllLiabilities();
            return liabilities;
        }
    }
}
