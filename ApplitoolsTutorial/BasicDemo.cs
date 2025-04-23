using Applitools.Images;
using NUnit.Framework;

namespace ApplitoolsTutorial
{

    [TestFixture]
    public class BasicDemo
    {
        private Eyes eyes;

        [Test]
        public void BasicTest()
        {
            // Initialize the eyes SDK and set your private API key.
            eyes = new Eyes();
           
            // Start the session and set app name and test name.
            eyes.Open("Demo App - Images C#", "Smoke Test - Images C#");

            // Visual checkpoint.
            eyes.Check(Target.Url("https://i.ibb.co/bJgzfb3/applitools.png"));

            // End the test.
            eyes.Close();
        }

        [TearDown]
        public void AfterEach()
        {
            eyes.AbortIfNotClosed();
        }
    }
}
