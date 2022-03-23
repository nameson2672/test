using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string FindPeak( int Time, string timePart){
                string peakStatus="test";
                if(timePart =="am"){
                    if( Time==12){
                        peakStatus = "Off-peak";
                    } 
                    if( Time<=6){
                        peakStatus = "Off-peak";
                    } 
                    if(Time>=7 && Time<=10){
                        peakStatus = "Mid-peak";
                    }
                    if(Time==11){
                        peakStatus = "On-peak";
                    } 
                }else{
                    if( Time==12){
                        peakStatus = "On-peak";
                    } 
                    if(Time<=5){
                        peakStatus = "On-peak";
                    }
                    if(Time>=6 && Time<=7){
                        peakStatus = "Mid-peak";
                    } 
                    if(Time>=8 && Time<=11){
                        peakStatus = "Off-peak";
                    }
                }

                return peakStatus;
            }

            string[] Week = { "Sunday", "Monday", "Tuesday", "Thusday","Wenesday", "Friday", "Saterday" };
            for(int i=0; i<7;i++){
                string pickDay = Week[i];
                Console.WriteLine(pickDay);
                for(int j=12; j<36; j++){
                    if(pickDay == "Sunday" || pickDay == "Monday"){
                        string meridiem = j<24? "am": "pm";
                        int time = j>12 && j<=24? j-12 : j-24;
                        string Weekendstr = Math.Abs(time) + " "+ meridiem + " : Off-peak";
                       Console.WriteLine(Weekendstr);
                    } else{
                        string meridiem = j<24? "am": "pm";
                        int time = j>12 && j<=24? j-12 : j-24;
                        string peakstatus = FindPeak(Math.Abs(time), meridiem);

                        string WeekdaysStr = Math.Abs(time) + " "+ meridiem + " : "+ peakstatus;
                        Console.WriteLine(WeekdaysStr);
                    }
                }
            }
        }
    }
}
