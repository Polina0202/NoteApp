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
        public static string Savefile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/NoteApp/";

        /// <summary>
        /// Полный путь до файла.
        /// </summary>
        private static string filepath = Path.Combine(Savefile, FileName);

        /// <summary>
        /// Сериализации данных.
        /// <param name="project">Проект.</param>
        /// <param name="savefile">Путь до папки сохранения.</param>
        /// </summary>
        public static void SaveToFile(Project project, string savefile)
        {
            Directory.CreateDirectory(savefile);
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(filepath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Десериализации данных.
        /// <param name="savefile">Путь до папки сохранения.</param>
        /// </summary>
        public static Project LoadFromFile(string savefile)
        {
            Project project;
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                using (StreamReader sr = new StreamReader(savefile))
                using (JsonTextReader reader = new JsonTextReader(sr))

                    project = (Project)serializer.Deserialize<Project>(reader);
            }
            catch
            {
                project = new Project();
            }

            return project;
        }
    }
}
