using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Newtonsoft.Json;

namespace NoteApp.UnitTest
{
    [TestFixture]
    public class ProjectManagerTests
    {
        public Project PrepareProject()
        {
            var sourceProject = new Project();
            sourceProject.Notes.Add(new Note()
            {
                Title = "Номера такси",
                Content = "Поехали: 90-22-90; Максим: 90-00-00; Яндекс: 50-00-00",
                CreatedTime = new DateTime(2020, 01, 01),
                UpdateTime = new DateTime(2020, 12, 10),
                Category = NoteCategory.Job
            });
            sourceProject.Notes.Add(new Note()
            {
                Title = "Платные подписки",
                Content = "КиноПоиск: 190р; ЮтубПремиум: 250р; ЯндексМузыка: 120р.",
                CreatedTime = new DateTime(2020, 02, 01),
                UpdateTime = new DateTime(2020, 12, 13),
                Category = NoteCategory.Finance
            });
            return sourceProject;
        }
        
        [Test]
        public void SaveToFile_CorrectFile_FileSaveCorrectly()
        {
            //Setup
            var sourceProject = PrepareProject();
            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
            var actualFileName = testDataFolder + @"\actualProject.json";
            var expectedFilename = testDataFolder + @"\expectedProject.json";

            //Act
            ProjectManager.SaveToFile(sourceProject, testDataFolder, actualFileName);

            //Assert
            var acltualFileContent = File.ReadAllText(actualFileName);
            var expectedFileContent = File.ReadAllText(expectedFilename);
            NUnit.Framework.Assert.AreEqual(expectedFileContent, acltualFileContent);
        }

        [Test]
        public void SaveToFile_NoneExitingFile_ThrowsException()
        {
            //Setup
            var location = Assembly.GetExecutingAssembly().Location + @"\BadTestData";

            //Act
            var actualResultExist = File.Exists(location);

            //Assert
            NUnit.Framework.Assert.IsFalse(actualResultExist);
        }

        [Test]
        public void LoadFromFile_CorrectFile_FileLoadCorrectly()
        {
            //Setup
            var expectedProject = PrepareProject();
            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
            var expectedFilename = testDataFolder + @"\expectedProject.json";

            //Act
            var actualProject = ProjectManager.LoadFromFile(expectedFilename);

            //Assert
           if (actualProject.Notes.Count == expectedProject.Notes.Count)
           {
               string expectedNote;
               string actualNote;
                for (var i = 0; i < actualProject.Notes.Count; i++)
                {
                    actualNote = JsonConvert.SerializeObject(actualProject.Notes[i]);
                    expectedNote = JsonConvert.SerializeObject(expectedProject.Notes[i]);
                    NUnit.Framework.Assert.AreEqual(actualNote, expectedNote);
                }
            }
        }

        [Test]
        public void LoadFromFile_GoodProject_ReturnSameProject()
        {
            //Setup
            var expectedProject = new Project();
            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
            var actualFilename = testDataFolder + @"\badNote.json";

            var badNote = "Hello, world!";
            StreamWriter f = new StreamWriter(actualFilename);
            f.WriteLine(badNote);
            f.Close();

            //Act
            var actualProject = ProjectManager.LoadFromFile(actualFilename);

            //Assert
            NUnit.Framework.Assert.AreEqual(JsonConvert.SerializeObject(actualProject), JsonConvert.SerializeObject(expectedProject));
        }
    }
}