using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Newtonsoft.Json;

namespace NoteApp.UnitTest
{
    [TestFixture]
    public class NoteTests
    {
        [Test]
        public void Name_NullValue_ReturnAdjustedValue()
        {
            //Setup
            var note = new Note();
            var sourceValue = "Без названия";
            var expectedValue = sourceValue;

            //Act
            note.Title = "";
            var actualValue = note.Title;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Name_GoodValue_ReturnsSameValue()
        {
            //Setup
            var note = new Note();
            var sourceValue = "Заметка";
            var expectedValue = sourceValue;

            //Act
            note.Title = sourceValue;
            var actualValue = note.Title;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Name_BadValue_ThrowsException()
        {
            //Setup
            var note = new Note();
            var sourceValue = "12345678901234567890123456789012345678901234567890!";

            //Assert
            NUnit.Framework.Assert.Throws<ArgumentException>
                (
                () =>
                {
                    //Act
                    note.Title = sourceValue;
                }
            );
        }

        [Test]
        public void CreatedTime_CorrectValue_ReturnCorrectValues()
        {
            //Setup
            var note = new Note();
            var sourceValue = new DateTime(1999, 02, 02);
            var expectedValue = sourceValue;

            //Act
            note.CreatedTime = sourceValue;
            var actualValue = note.CreatedTime;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }


        [Test]
        public void UpdateTime_CorrectValue_ReturnCorrectValues()
        {
            //Setup
            var note = new Note();
            var sourceValue = new DateTime(1999, 02, 02);
            var expectedValue = sourceValue;

            //Act
            note.UpdateTime = sourceValue;
            var actualValue = note.UpdateTime;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Category_CorrectValue_ReturnCorrectValues()
        {
            //Setup
            var note = new Note();
            var sourceValue = NoteCategory.Other;
            var expectedValue = sourceValue;

            //Act
            note.Category = sourceValue;
            var actualValue = note.Category;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Content_CorrectValue_ReturnCorrectValues()
        {
            //Setup
            var note = new Note();
            var sourceValue = "Тут будет отображаться текст вашей заметки...";
            var expectedValue = sourceValue;

            //Act
            note.Content = sourceValue;
            var actualValue = note.Content;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Creation_CorrectValue_ReturnCorrectValues()
        {
            //Setup
            var note = new Note();
            var sourceValue = new DateTime(2020, 02, 02);
            var expectedValue = sourceValue;

            //Act
            note.Creation = sourceValue;
            var actualValue = note.Creation;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Clone_CorrectNote_ReturnCorrectNote()
        {
            //Setup
            var expectedNote = new Note
            {
                Title = "Расписание клуба",
                CreatedTime = new DateTime(1900,01,01),
                UpdateTime = new DateTime(2020, 01, 01),
                Content = "пн-чт: 09:00 - 21:00; пт-сб: 08:00-19:00.",
                Category = NoteCategory.HealthSport
            };

            //Act
            var actualNote = expectedNote.Clone() as Note;
            var expectedResult = JsonConvert.SerializeObject(expectedNote);
            var actualResult = JsonConvert.SerializeObject(actualNote);

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
