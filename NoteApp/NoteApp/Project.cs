using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace NoteApp
{
    /// <summary>
    /// Класс "Проект".
    /// Содержит список всех заметок, созданных в приложении.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Словарь заметок.
        /// </summary>
        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();
    }
}
