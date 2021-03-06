﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TOCLogin.Models
{
    public class Project : Entity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public virtual List<Tree> Trees { get; set; }
        public virtual List<Cloud> Clouds { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string CreateBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}