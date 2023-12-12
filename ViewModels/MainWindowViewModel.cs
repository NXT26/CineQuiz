using System.Collections.ObjectModel;
using cinequiz.Models;

namespace cinequiz.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<QuizQuestion> Questions { get; set; }

        public MainWindowViewModel()
        {
            Questions = new ObservableCollection<QuizQuestion>();
            // Здесь можно добавить примеры вопросов
        }
    }
}