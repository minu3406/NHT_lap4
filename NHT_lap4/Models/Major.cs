using System.ComponentModel.DataAnnotations;

namespace NHT_lap4.Models
{
    public class Major
    {
        public Major()
        {
            Learners = new HashSet<Learner>();
        }

        [Key]
        public int MajorID { get; set; }
        public string MajorName { get; set; }

        // Quan hệ 1 - Nhiều với bảng Learner
        public virtual ICollection<Learner> Learners { get; set; }
    }
}
