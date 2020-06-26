using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_MVVM_Custom.ViewModel
{
    public class BookViewModel : ViewModelBase
    {
        public Model.Book Book;

        public BookViewModel(Model.Book book)
        {
            this.Book = book;
        }

        public string Title
        {
            get { return Book.Title; }
            set
            {
                Book.Title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Author
        {
            get { return Book.Author; }
            set
            {
                Book.Author = value;
                OnPropertyChanged("Author");
            }
        }

        public int Count
        {
            get { return Book.Count; }
            set
            {
                Book.Count = value;
                OnPropertyChanged("Count");
            }

        }

        // -----------------------------------------------------

        private Command.RelayCommand getItemCommand;

        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null)
                {
                    getItemCommand = new Command.RelayCommand(()=>GetItem());
                }
                return getItemCommand;
            }
        }


        private Command.RelayCommand giveItemCommand;

        public ICommand GiveItemCommand
        {
            get
            {
                if (giveItemCommand == null)
                {
                    giveItemCommand = new Command.RelayCommand(GiveItem, CanGiveItem);
                }
                return giveItemCommand;
            }
        }

        private void GetItem()
        {
            Count++;
        }

        private void GiveItem()
        {
            Count--;
        }

        private bool CanGiveItem()
        {
            return Count > 0;
        }


    }
}