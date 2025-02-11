

namespace Assginment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Demo

            #region Implicitly Typed Local Variable [Var , Dynamic]

            #region Var

            //// string Data = "Ahmed";

            //var Data = "Ahmed"; // Implicit Type
            //                    // Compiler WillDetect The Datatype Of Variable at Compilation Time
            //                    // Based On its Intial Value

            //// var X = null; // Invalid
            //// Var Can't be Intialized With null

            //Data = null; // Valid

            //// Data = 5; // Invalid
            //// After Intialization , You can't change the type of Var

            //// var X; // Invalid
            //// Var Must be Intialized

            #endregion

            #region Dynamic

            //dynamic Data = "Adham";
            //// Clr Will Detect Datatype Of Variable At Runtime
            //// Based On it's last Assigned value

            //dynamic X; // Valid
            //// Can Declare Variable With Dynamic Without Intialization;

            //dynamic Y = null; // Valid
            //// Can Be Intialized With NUll

            //Data = 2;

            //// After intialization , You Can Change Datatype of Variable

            //Data = true;
            //Data = 3.3;
            //Data = 'A';

            #endregion

            // Can't Use Var in Parameter Or Return Type Or Attribute at Class
            // We Use It Only To Declare Local Variable

            //for (var i = 0; i < 10; i++) { }
            //foreach (var item in args) { }

            // Var Is Recommended
            // Errors => Compilation Time

            // var X = null; // Compilation Error

            //dynamic Y = null;
            //Console.WriteLine(Y); //RuntimeBinderException

            #endregion

            #region Extension Methods

            

            int X = 12345;

            
            // int Y = ExtensionMethod.Reverse(X);

            //int Y = X.Reverse();


            #endregion

            #endregion
        }
    }
}
