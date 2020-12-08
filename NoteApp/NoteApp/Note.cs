using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс "Заметка".
    /// Хранит информацию о названии, категории, время создания/изменения и саму заметку.
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// "Заголовок"
        /// </summary>
        private string _title;

        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategory _category;

        /// <summary>
        /// Содержание заметки
        /// </summary>
        private string _content;

        /// <summary>
        /// Время создания
        /// </summary>
        private DateTime _сreationTime = DateTime.Now;

        /// <summary>
        ///Время изменения
        /// </summary>
        private DateTime _changeTime = DateTime.Now;

        /// <summary>
        /// Свойство заголовка.
        ///Количество символов не должно превышать 50ти символов.
        ///Устанавливает название по умолчанию, если такого не было найдено.
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Назване заметки не может превышать 50 символов. Измените название!");
                }
                else
                {
                    if (value.Length != 0)
                    {
                        _title = value;
                    }
                    else _title = "Без названия";
                }
            }
        }

        /// <summary>
        /// Свойство для записи времени последнего изменения.
        /// </summary
        public DateTime Creation
        {
            get
            {
                return _changeTime;
            }
            set
            {
                _changeTime = value;
            }
        }
        /// <summary>
        /// Свойство категории заметки.
        /// Изменяет время последнего изменение при смене категории.
        /// </summary>
        public NoteCategory Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        /// <summary>
        /// Свойство содержания заметки.
        /// Изменяет время последнего изменение при изменении содержания заметки.
        /// </summary>
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
            }
        }

        /// <summary>
        /// Свойство времени создания заметки.
        /// </summary>
        public DateTime CreationTime
        {
            get
            {
                return _сreationTime;
            }
            set
            {
                _сreationTime = value;
            }
        }

        /// <summary>
        /// Свойство изменения времени заметки.
        /// </summary>
        public DateTime UpdateTime
        {
            get
            {
                return _changeTime;
            }
            set
            {
                _changeTime = value;
            }
        }

        /// <summary>
        /// Метод клонирования.
        /// </summary>
        /// <returns>Возвращает копию класса Note</returns>
        public object Clone()
        {
            return new Note
            {
                Title = this.Title,
                Content = this.Content,
                UpdateTime = this.UpdateTime,
                Category = this.Category
            };
        }
    }
}