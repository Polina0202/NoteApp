using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс «Менеджер проекта».
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Имя файла для сериализации и десериализации данных.
        /// Закрытая константа.
        /// </summary>
        private const string FileName = "NoteApp.notes";

        /// <summary>
        /// Путь до папки сохранения.
        /// </summary>
        public static string SaveFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\";

        /// <summary>
        /// Полный путь до файла.
        /// </summary>
        public static string FolderPath = Path.Combine(SaveFile, FileName);
        
        /// <summary>
        /// Сериализации данных.
        /// <param name="project">Проект.</param>
        /// <param name="savefile">Путь до папки сохранения.</param>
        /// </summary>
        public static void SaveToFile(Project project, string savefile, string folderpath)
        {
            if (!Directory.Exists(savefile))
            {
                Directory.CreateDirectory(savefile);
            }

            JsonSerializer serializer = new JsonSerializer();           
            using (StreamWriter sw = new StreamWriter(folderpath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Десериализации данных.
        /// <param name="savefile">Путь до папки сохранения.</param>
        /// </summary>
       public static Project LoadFromFile(string folderpath)
        {
            Project project;
            JsonSerializer serializer = new JsonSerializer();

            try
            {
                using (StreamReader sr = new StreamReader(folderpath))
                using (JsonTextReader reader = new JsonTextReader(sr))
                {
                    project = (Project)serializer.Deserialize<Project>(reader);
                }
            }
            catch
            {
                project = new Project();
            }
            return project;
        }
    }
}