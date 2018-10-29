namespace KeyPay.DomainModels.V2.TimeAndAttendance
{
    public class TimeAndAttendanceKioskModel
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public int? LocationId { get; set; }
        public string Name { get; set; }
        public string TimeZone { get; set; }
        public bool AllowHigherClassificationSelection { get; set; }
        public WhiteLabelBrandingModel Branding { get; set; }
        public bool IsLocationRequired { get; set; }
        public bool IsWorkTypeRequired { get; set; }
        public bool RestrictLocationsForEmployees { get; set; }
        public bool? AllowEmployeeShiftSelection { get; set; }
        public int? ClockOnWindowMinutes { get; set; }
        public int? ClockOffWindowMinutes { get; set; }
        public bool? IsPhotoRequired { get; set; }
        public bool CanAddEmployees{ get; set; }
    }
}