﻿namespace IncidentManagement.Models
{
    public class CancelOrResolveIncidentOptions
    {
        public string IncidentTitle { get; set; }
        public string IncidentDescription { get; set; }
        public string IncidentCategory { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByUserID { get; set; }
        public string ServiceName { get; set; }
        public string ImagePath { get; set; }
        public string IncidentStatus { get; set; }
    }
}
