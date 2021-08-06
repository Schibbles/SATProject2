using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SATProject2.DATA.EF
{
    public class StudentMetadata
    {
        [Required(ErrorMessage = "Student First Name is required")]
        [StringLength(15, ErrorMessage = "*Name length must be 15 characters or less")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Student Last Name is required")]
        [StringLength(15, ErrorMessage = "*Name length must be 15 characters or less")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(15, ErrorMessage = "*Major must be 15 characters or less")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Major { get; set; }

        [StringLength(50, ErrorMessage = "*Address must be 50 characters or less")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Address { get; set; }

        [StringLength(50, ErrorMessage = "*Value must be 50 characters or less")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string City { get; set; }

        [StringLength(2, MinimumLength = 2, ErrorMessage = "*Value must be 2 characters")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string State { get; set; }

        [StringLength(5, MinimumLength = 5, ErrorMessage = "*Value must be 5 characters")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string ZipCode { get; set; }

        [StringLength(13, ErrorMessage = "*Value must be 13 characters or less")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "*Email is required")]
        [StringLength(60)]
        public string Email { get; set; }

        [StringLength(100)]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "*Student Status is required")]
        public int SSID { get; set; }
    }
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
        [Display(Name = "Student Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }

    public class StudentStatusMetadata
    {
        [Required(ErrorMessage = "*SSName is required")]
        [StringLength(30, ErrorMessage = "*Status Name must be 30 characters or less")]
        [Display(Name = "Status Name")]
        public string SSName { get; set; }

        [StringLength(250, ErrorMessage = "*Description must be 250 characters or less")]
        [Display(Name = "Status Description")]
        public string SSDescription { get; set; }
    }
    [MetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }

    public class EnrollmentMetadata
    {
        [Required(ErrorMessage = "*Student is required")]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "*Scheduled Class is required")]
        [Display(Name = "Scheduled Class ID")]
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "*Enrollment Date is required")]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
    }
    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment { }

    public class ScheduledClassMetadata
    {
        [Required(ErrorMessage = "*Course ID is required")]
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "*Start Date is required")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "*End Date is required")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "*Instructor Name is required")]
        [Display(Name = "Instructor Name")]
        [StringLength(40)]
        public string InstructorName { get; set; }

        [Required(ErrorMessage = "*Location is required")]
        [StringLength(20, ErrorMessage = "*Location must be 20 characters or less")]
        public string Location { get; set; }

        [Required(ErrorMessage = "*Scheduled Class Status is required")]
        [Display(Name = "Scheduled Class Status")]
        public int SCSID { get; set; }
    }
    [MetadataType(typeof(ScheduledClass))]
    public partial class ScheduledClass { }

    public class ScheduledClassStatusMetadata
    {
        [Required(ErrorMessage = "*Scheduled Class Status is required")]
        [StringLength(50, ErrorMessage = "*Scheduled class statuse must be 50 characters or less")]
        [Display(Name = "Scheduled Class Status")]
        public int SCSName { get; set; }
    }
    [MetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }

    public class CourseMetadata
    {
        [Required(ErrorMessage = "*Course Name is required")]
        [StringLength(50, ErrorMessage = "*Course Name must be 50 characters or less")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "*Course Description is required")]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }

        [Required(ErrorMessage = "*Credit Hours required")]
        [Display(Name = "Credit Hours")]
        public short CreditHours { get; set; }

        [StringLength(250, ErrorMessage = "*Curriculum must be 250 characters or less")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Curriculum { get; set; }

        [StringLength(500, ErrorMessage = "*Notes must be 500 characters or less")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Notes { get; set; }

        [Required(ErrorMessage = "*Activity is required")]
        [Display(Name = "Is Active")]
        public byte IsActive { get; set; }
    }
    [MetadataType(typeof(CourseMetadata))]
    public partial class Course { }
}
