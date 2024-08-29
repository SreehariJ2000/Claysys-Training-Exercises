using System;
namespace HelloWorld
{
   
    public delegate void ClickEventHandler();

    public class Button
    {
        // Declare the event using the delegate
        public event ClickEventHandler Click;

        // Method to trigger the event
        public void OnClick()
        {
            // Check if there are any subscribers to the event
            if (Click != null)
            {
                Click();  // Raise the event
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();

            // Subscribe to the event
            button.Click += HandleButtonClick;

            // Trigger the event
            button.OnClick();
        }

        // Event handler method
        public static void HandleButtonClick()
        {
            Console.WriteLine("Button clicked!");
        }
    }

}