using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrafficLawsTest.DataSource.Models
{
    /// <summary>
    /// Результаты тестирования пользователей
    /// </summary>
    public class UserTest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public DateTime DateStamp { get; set; }

        public int Result { get; set; }
        public int Total { get; set; }

        public virtual User User { get; set; }
    }
}
