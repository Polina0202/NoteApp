using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NoteApp
{
    /// <summary>
    /// Класс "Категория".
    /// Содержит все категории заметок.
    /// </summary>
    public enum NoteCategory
    {
        [Description("Работа")]
        Job,
        [Description("Дом")]
        Home,
        [Description("Здоровье и Спорт")]
        HealthSport,
        [Description("Люди")]
        People,
        [Description("Документы")]
        Documents,
        [Description("Финансы")]
        Finance,
        [Description("Другое")]
        Other
    }
}
