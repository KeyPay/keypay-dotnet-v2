namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerEmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }        
    }

    public class ManagerLeaveEmployeeModel : ManagerEmployeeModel
    {
        public string CanApprove { get; set; }
    }

}
