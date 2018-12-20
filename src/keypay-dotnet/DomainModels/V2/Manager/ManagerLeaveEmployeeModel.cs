namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerEmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CanApprove { get; set; }
    }

    public class ManagerLeaveEmployeeModel : ManagerEmployeeModel
    {
    }

    public class ManagerTimesheetEmployeeModel : ManagerEmployeeModel
    {
        public string CanCreate { get; set; }
    }

    public class ManagerExpenseEmployeeModel : ManagerEmployeeModel
    {
        public bool CanCreate { get; set; }
    }

}
