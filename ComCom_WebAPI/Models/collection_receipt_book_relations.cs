using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.Models
{
    public partial class collection_receipt_book_relations
    {
        public uint id_parent { get; set; }
        public uint id_receipt_book { get; set; }

        public virtual collection_receipt_books id_parentNavigation { get; set; } = null!;
        public virtual collection_receipt_books id_receipt_bookNavigation { get; set; } = null!;
    }
}
