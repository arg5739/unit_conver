using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    static public double pi = 3.1415926535897932384;
    // for temperature conversion

    /**
* this function perform the temperature. conversion from Celsius to Fahrenheit
* @param       value1    (double) temp to convert 

* @return              (double) Converted tempeature
*/
	public double celsiusToFah(double value1)
	{
        value1 = value1 * 1.8;
        value1 = value1 + 32;
       return value1;
	}

    /**
* this function perform the temperature conversion from Fahrenheit to Celsius
* @param       value1    (double) temp to convert 

* @return              (double) Converted tempeature
*/
    public double fartoCels(double value1)
    {
        value1 = value1 - 32;
        value1 = value1 / 1.8;
        return value1;
    }

    /**
* this function perform the temperature conversion from celsius to Kelvin
* @param       value1    (double) temp to convert 

* @return              (double) Converted tempeature
*/
    public double celciTokelvin(double value1)
    {
        value1 = value1 + 273.15;
        return value1;
    }

    /**
* this function perform the temperature conversion from Kelvin to celsius.
* @param       value1    (double) temp to convert 

* @return              (double) Converted tempeature
*/
    public double kelvintoCel(double value1)
    {
        
        value1 = value1 - 273.15;
        return value1;
    }

    /**
* this function perform the temperature conversion from fahrenheit to Kelvin.
* @param       value1    (double) temp to convert 

* @return              (double) Converted tempeature
*/
    public double fartoKelvin(double value1)
    {
        value1 = value1 + 459.67;
        value1 = value1 * 5 ;
        value1 = value1 / 9;
        return value1;

    }

    /**
* this function perform the temperature conversion from Kelvin to fahrenheit.
* @param       value1    (double) temp to convert 

* @return              (double) Converted tempeature
*/
    public double KelvintoFah(double value1)
    {
        
        value1 = value1 * 9;
        value1 = value1 / 5;
        value1 = value1 - 459.67;
        return value1;
    }



    // Angle conversions



   
    /**
* this function perform the temperature conversion from radian to degree.
* @param       value1    (double) temp to convert 

* @return              (double) Converted tempeature
*/
    public double degreeToRadian(double value1)
    {

        value1 = value1 * pi;
        value1 = value1 / 180;
        return value1;
    }

    /**
* this function perform the temperature conversion from degree to radian.
* @param       value1    (double) temp to convert 

* @return              (double) Converted tempeature
*/
    public double RadianToDegree(double value1)
    {

        value1 = value1 * 180;
        value1 = value1 / pi;
        return value1;
    }
	
}
