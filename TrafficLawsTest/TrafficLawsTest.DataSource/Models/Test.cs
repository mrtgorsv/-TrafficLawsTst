using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrafficLawsTest.DataSource.Models
{
    
    /// <summary>
    /// Тест ПДД
    /// </summary>
    [Serializable]
    public class Test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Seq { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TestTime { get; set; }

        public virtual ICollection<TestPart> TestParts { get; set; }
    }
}
