using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Newtonsoft.Json;

namespace NoteApp.UnitTest
{
    [TestFixture]
    public class ProjectTests
    {
        [Test]
        public void Project_CreateProject_ReturnAdjustedProject()
        {
            //Setup
            var note = new Note
            {
                CreatedTime = new DateTime(1900, 01, 01),
                UpdateTime = new DateTime(2020, 01, 01),
                Category = NoteCategory.Other
            };
            var sourceProject = new Project();
            
            //Act
            sourceProject.Notes.Add(note);

            //Assert
            NUnit.Framework.Assert.IsNotNull(sourceProject);
        }
    }
}
