using Day20_MoodAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSad_ReturnSad()
        {
            HappySad happySad = new HappySad("iam in sad mood");
            string Result = happySad.AnalysingMood();

            Assert.AreEqual("SAD", Result);
        }

        [TestMethod]
        public void GivenHappy_ReturnHappy()
        {
            HappySad happySad = new HappySad("iam in happy mood");
            string Result = happySad.AnalysingMood();

            Assert.AreEqual("HAPPY", Result);
        }


        /*[TestMethod]
        public void GivenNull_ReturnHappy()
        {
            HappySad happySad = new HappySad(null);
            string result = happySad.AnalysingMood();
            Assert.AreEqual("HAPPY", result);
        }*/


        [TestMethod]
        public void GivenNull_RetunCustomException()
        {
            try
            {
                HappySad happySad = new HappySad(" ");
                string result = happySad.AnalysingMood();
            }
            catch (UC3_CustomException ex)
            {
                Assert.AreEqual("message should not be null", ex.Message);
            }
        }

        [TestMethod]
        public void GivenEmpty_RetunCustomException()
        {
            try
            {
                HappySad happySad = new HappySad("");
                string result = happySad.AnalysingMood();
            }
            catch (UC3_CustomException ex)
            {
                Assert.AreEqual("message should not be empty", ex.Message);
            }
        }





        [TestMethod]
        public void GivingClassNameRight_ReturnsObject()
        {
            HappySad happySad = new HappySad(" ");
            MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySad", "HappySad");
            object MyObj = MoodAnalyserFactory.FactoryMethod(factory);
            happySad.Equals(MyObj);
        }


        [TestMethod]
        public void GivingClassNameWrong_RetunCustomException()
        {
            try
            {
                HappySad happySad = new HappySad(" ");
                MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySa", "HappySad");
                var MyObj = MoodAnalyserFactory.FactoryMethod(factory);
            }
            catch (UC3_CustomException ex)
            {
                Assert.AreEqual("class name is wrong", ex.Message);
            }
        }


        [TestMethod]
        public void GivingConstructorWrong_RetunCustomException()
        {
            try
            {
                HappySad happySad = new HappySad(" ");
                MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySad", "HappySa");
                var MyObj = MoodAnalyserFactory.FactoryMethod(factory);
            }
            catch (UC3_CustomException ex)
            {
                Assert.AreEqual("constructor name is wrong", ex.Message);
            }
        }




        [TestMethod]
        public void GivingMessageRight_ReturnsObject()
        {
            HappySad happySad = new HappySad("iam Happy");
            MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySad", "HappySad");
            object MyObj = MoodAnalyserFactory.InvokeMethod(factory, "iam Happy");
            happySad.Equals(MyObj);
        }


        [TestMethod]
        public void GivingMessageWrong_RetunCustomException()
        {
            try
            {
                HappySad happySad = new HappySad("iam in any mood");
                MoodAnalyserFactory factory = new MoodAnalyserFactory("MoodAnalyser.HappySad", "HappySad");
                var MyObj = MoodAnalyserFactory.InvokeMethod(factory, "iam in any mood");
            }
            catch (UC3_CustomException ex)
            {
                Assert.AreEqual("class name is wrong", ex.Message);
            }
        }





        [TestMethod]
        public void GivingFieldName_Wrong_RetunCustomException()
        {
            string Expected = "wrong field name";
            try
            {
                var result = Reflector.SetField("iam Happy", "WrongField");
            }
            catch (UC3_CustomException ex)
            {
                Assert.AreEqual(Expected, ex.Message);
            }
        }

        [TestMethod]
        public void GiveingMessage_Wrong_RetunCustomException()
        {
            string Expected = "message should not be null";
            try
            {
                var result = Reflector.SetField(null, "Message");
            }
            catch (UC3_CustomException ex)
            {
                Assert.AreEqual(Expected, ex.Message);
            }
        }

    }
}
