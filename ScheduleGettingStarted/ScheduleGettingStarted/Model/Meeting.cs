using System;
using Xamarin.Forms;
namespace ScheduleGettingStarted
{
    /// <summary>   
    /// Represents custom data properties.   
    /// </summary>  
    public class Meeting : ContentPage
    {
        public string EventName { get; set; }
        public string Organizer { get; set; }
        public string ContactID { get; set; }
        public int Capacity { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }


        public bool AllDay { get; set; }

        public Color color { get; set; }


    }
}
