using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrafficLawsTest.DataSource.Models
{
    [Serializable]
    public class TestPart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Seq { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        public int CorrectAnswer { get; set; }

        public virtual ICollection<TestPartAnswer> Answers { get; set; }
    }
}
