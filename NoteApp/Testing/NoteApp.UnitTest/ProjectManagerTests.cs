using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Newtonsoft.Json;
using NUnit.Framework.Internal;

namespace NoteApp.UnitTest
{
    [TestFixture]
    public class ProjectManagerTests
    {
        public Project SetUp()
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

        public string TestDataFolder()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            var testDataFolder = Path.GetDirectoryName(location) + @"\TestData";
            return testDataFolder;
        }

        public string ActualFileName()
        {
            var actualFileName = TestDataFolder() + @"\actualProject.json";
            return actualFileName;
        }

        public string ExpectedFilename()
        {
            var expectedFilename = TestDataFolder() + @"\expectedProject.json";
            return expectedFilename;
        }

        [Test]
        public void SaveToFile_CorrectFile_FileSaveCorrectly()
        {
            //Setup
            var sourceProject = SetUp();
            var testDataFolder = TestDataFolder();
            var actualFileName = ActualFileName();
            var expectedFilename = ExpectedFilename();

            //Act
            ProjectManager.SaveToFile(sourceProject, testDataFolder, actualFileName);

            //Assert
            var actualFileContent = File.ReadAllText(actualFileName);
            var expectedFileContent = File.ReadAllText(expectedFilename);
            NUnit.Framework.Assert.AreEqual(expectedFileContent, actualFileContent);
        }

        [Test]
        public void SaveToFile_NoneExistingFolder_FileSaveCorrectly()
        {
            //Setup
            var sourceProject = SetUp();
            var testDataFolder = TestDataFolder();
            var actualFileName = ActualFileName();
            var actualFolder = testDataFolder + @"\TestSaveToFile";
            
            if (Directory.Exists(actualFolder))
            {
                Directory.Delete(actualFolder, true);
            }

            //Act
            ProjectManager.SaveToFile(sourceProject, actualFolder, actualFileName);

            //Assert
            NUnit.Framework.Assert.True(File.Exists(actualFileName));
        }

        [Test]
        public void LoadFromFile_CorrectFile_FileLoadCorrectly()
        {
            //Setup
            var expectedProject = SetUp();
            var expectedFilename = ExpectedFilename();

            //Act
            var actualProject = ProjectManager.LoadFromFile(expectedFilename);

            //Assert
            if (actualProject.Notes.Count == expectedProject.Notes.Count)
            {
                for (var i = 0; i < actualProject.Notes.Count; i++)
                {
                    Assert(actualProject.Notes[i], expectedProject.Notes[i]);
                }
            }
        }

        [Test]
        public void LoadFromFile_NotCorrectProject_ReturnSameProject()
        {
            //Setup
            var expectedProject = new Project();
            var testDataFolder = TestDataFolder();
            var actualFileName = testDataFolder + @"\badNote.json";

            var badNote = "Hello, world!";
            StreamWriter f = new StreamWriter(actualFileName);
            f.WriteLine(badNote);
            f.Close();

            //Act
            var actualProject = ProjectManager.LoadFromFile(actualFileName);

            //Assert
            if (actualProject.Notes.Count == expectedProject.Notes.Count)
            {
                for (var i = 0; i < actualProject.Notes.Count; i++)
                {
                    Assert(actualProject.Notes[i], expectedProject.Notes[i]);
                }
            }
        }

        public static void Assert(Note note1, Note note2)
        {
            NUnit.Framework.Assert.AreEqual(note1.Title, note2.Title);
            NUnit.Framework.Assert.AreEqual(note1.Content, note2.Content);
            NUnit.Framework.Assert.AreEqual(note1.Category, note2.Category);
            NUnit.Framework.Assert.AreEqual(note1.CreatedTime, note2.CreatedTime);
            NUnit.Framework.Assert.AreEqual(note1.UpdateTime, note2.UpdateTime);
        }
    }
}