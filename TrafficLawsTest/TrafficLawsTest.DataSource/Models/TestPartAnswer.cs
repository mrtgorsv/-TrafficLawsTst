using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrafficLawsTest.DataSource.Models
{
    [Serializable]
    public partial class TestPartAnswer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("TestPart")]
        public int TestPartId { get; set; }

        public string Text { get; set; }

        public string Options { get; set; }

        public int AnswerNumber { get; set; }

        public virtual TestPart TestPart { get; set; }
    }
}
