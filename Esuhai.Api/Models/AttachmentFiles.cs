using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class AttachmentFiles
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string FilePath { get; set; }
        public string ItemType { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string FileName { get; set; }
    }
}
