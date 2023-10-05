using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace new_mongo
{
    [Serializable]
    public class MeetingRoomsModel
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string MeetingID { get; set; }



        [BsonElement("employee_id"), BsonRepresentation(BsonType.String)]
        public string EmployeeID { get; set; }



        [BsonElement("meeting_date"), BsonRepresentation(BsonType.String)]
        public string MeetingDate { get; set; }



        [BsonElement("employee_name"), BsonRepresentation(BsonType.String)]
        public string EmployeeName { get; set; }



        [BsonElement("meeting_start_time"), BsonRepresentation(BsonType.String)]
        public string MeetingStartTime { get; set; }



        [BsonElement("meeting_end_time"), BsonRepresentation(BsonType.String)]
        public string MeetingEndTime { get; set; }



        [BsonElement("meeting_room"), BsonRepresentation(BsonType.String)]
        public string MeetingRoom { get; set; }
    }

}
