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
        /// Индекс текущей заметки.
        /// </summary>
        public int SelectedIndex { get; set; }

        /// <summary>
        /// Словарь заметок.
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        /// <summary>
        /// Сортировка списка заметок по дате изменения.
        /// </summary>
        public List<Note> SortNotes(List<Note> note)
        {
            return note.OrderByDescending(item => item.UpdateTime).ToList();
        }
    }
}
