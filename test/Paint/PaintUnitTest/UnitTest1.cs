using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paint;

namespace PaintUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkLoopAndIfValidation()
        {
            String input;
            TextBox textbox = new TextBox();

            input = "counter = 5 \r\n If counter = 5 then \r\n radius + 25 \r\n Circle 5 \r\n EndIf";

            textbox.Text = input;
            Validation validation = new Validation(textbox);

            Boolean expectedOutcome;
            Boolean realOutcome;
            expectedOutcome = true;
            validation.checkLoopAndIfValidation();
            realOutcome = validation.isValidCommand;
            Assert.AreEqual(expectedOutcome, realOutcome);

        }
        //Testing if it validates a line of command
        [TestMethod()]
        public void checkLineValidationTest()
        {
            String input;
            TextBox textbox = new TextBox();
            input = "Rectangle 100, 100";

            textbox.Text = input;
            Validation validation = new Validation(textbox);

            Boolean expectedOutcome;
            Boolean realOutcome;
            expectedOutcome = true;
            validation.checkLineValidation(input);
            realOutcome = validation.isValidCommand;
            Assert.AreEqual(expectedOutcome, realOutcome);
        }

        //Testing if it validates a variable
        [TestMethod()]
        public void checkIfVariableDefinedTest()
        {
            String input;
            TextBox textbox = new TextBox();
            input = "Radius = 20 \r\n Circle Radius";

            textbox.Text = input;
            Validation validation = new Validation(textbox);

            Boolean expectedOutcome;
            Boolean realOutcome;
            expectedOutcome = true;
            validation.checkIfVariableDefined("radius");
            realOutcome = validation.isValidCommand;
            Assert.AreEqual(expectedOutcome, realOutcome);
        }
    }
}
