namespace OOP
{
    public class Encapsulation
    {
        public void ServeCoffe()
        {
            var express = new ExpressoMachine();
            express.On();
            express.PrepareCoffe();
            express.Off();

            //An Advantage of encapsulation is that the changes become transparently,
            //who it is calling it is not going to be affected
            //with the behavior change.

            //Just the result it is important. Encapsulating behavior that are being done privately in the class.
        }

        public class ExpressoMachine
        {
            //With encapsulation we can hide the way something is done,
            //giving the people who are calling the method,
            //just the result.

            public void On()
            {

            }

            public void PrepareCoffe()
            {

            }

            public void Off()
            {

            }
        }
    }
}
