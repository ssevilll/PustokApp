using PustokAppMvc.Models;

namespace PustokAppMvc.ViewModel
{
    public class BookVm
    {
        public Book Book { get; set; } = null!;
        public List<Book> RelatedBooks { get; set; } = null!;
    }
}
