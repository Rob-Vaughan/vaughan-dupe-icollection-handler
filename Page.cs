
namespace Vaughan_Generic_Duplicate_Handler
{
    public class Page
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string DocumentType { get; set; }
        public DateTime ImportDate = DateTime.Now;
        public int PageNumber = 1;
    }
}
