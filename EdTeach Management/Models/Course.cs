using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Models
{
    public class Course
    {
        string id;
        string title;
        string instructor;
        string batch;
        string type;
        string duration;
        string price;
        string lvel;
        string lectures;
        string status;

        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Instructor { get => instructor; set => instructor = value; }
        public string Batch { get => batch; set => batch = value; }
        public string Type { get => type; set => type = value; }
        public string Duration { get => duration; set => duration = value; }
        public string Price { get => price; set => price = value; }
        public string Lvel { get => lvel; set => lvel = value; }
        public string Lectures { get => lectures; set => lectures = value; }
        public string Status { get => status; set => status = value; }
    }
}
