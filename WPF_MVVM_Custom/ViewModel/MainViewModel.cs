using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WPF_MVVM_Custom.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<BookViewModel> BooksList { get; set; } 

        public MainViewModel()
        {
            BooksList = new ObservableCollection<BookViewModel>();
            BooksList.Add(new BookViewModel(new Model.Book("Колобок", null, 3)));
            BooksList.Add(new BookViewModel(new Model.Book("CLR via C#", "Джеффри Рихтер", 1)));
            BooksList.Add(new BookViewModel(new Model.Book("Война и мир", "Л.Н. Толстой", 2)));
        }
    }
}
