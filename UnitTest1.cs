using NUnit.Framework;

namespace NUnitTestProject3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Define the data, so it does not clutter the code

            // Define browser object

            // Define the first url

            // Define the element to be clicked

            // Define the expected details
        }

        [Test]
        public void Test1()
        {
            // Keep the code free from the data
            // Assume almost anything can go wrong
            // Give as much information as possible about failures

            // https://www.testdome.com/t/20644099157a4e97b0b50793bcb32cb0

            // Create instance of the broswer object

            // If creation fails, Assert.Fail with "Broswer creation failed" plus reason

            // Navigate to the first url

            // If navigation fails, Assert.Fail with "Naigate to first url failed" plus reason

            // Find the element to be tested, probably find element by ID or some other attribute

            // If find element fails, Assert.Fail with "Find element failed" plus reason

            // Execute click() on the element

            // Check that the click() executed properly

            // If click() fails, Assert.Fail with "Click failed" plus reason

            // Compare the details expeceted after the click()

            // If actual details don't match those expected, Assert.Fail with "Details don't match" plus actual details and expected details

            Assert.Pass();
        }
    }
}