using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Statyczna klasa zawierajaca podstawowe metody przeliczania jednostek
/// </summary>
public static class KJ
{
    public static double m(double wartosc, String jednostka)
    {
        if (jednostka == "mm")
            return wartosc *= 0.001;
        else if (jednostka == "cm")
            return wartosc *= 0.01;
        else if (jednostka == "dm")
            return wartosc *= 0.1;
        else if (jednostka == "m")
            return wartosc *= 1;
        else if (jednostka == "km")
            return wartosc *= 1000;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double dm(double wartosc, String jednostka)
    {
        if (jednostka == "mm")
            return wartosc *= 0.01;
        else if (jednostka == "cm")
            return wartosc *= 0.1;
        else if (jednostka == "dm")
            return wartosc *= 1;
        else if (jednostka == "m")
            return wartosc *= 10;
        else if (jednostka == "km")
            return wartosc *= 10000;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double cm(double wartosc, String jednostka)
    {
        if (jednostka == "mm")
            return wartosc *= 0.1;
        else if (jednostka == "cm")
            return wartosc *= 1;
        else if (jednostka == "dm")
            return wartosc *= 10;
        else if (jednostka == "m")
            return wartosc *= 100;
        else if (jednostka == "km")
            return wartosc *= 100000;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double mm(double wartosc, String jednostka)
    {
        if (jednostka == "mm")
            return wartosc *= 1;
        else if (jednostka == "cm")
            return wartosc *= 10;
        else if (jednostka == "dm")
            return wartosc *= 100;
        else if (jednostka == "m")
            return wartosc *= 1000;
        else if (jednostka == "km")
            return wartosc *= 1000000;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    // Przeliczniki jednostek objetosci
    public static double m3(double wartosc, String jednostka)
    {
        if (jednostka == "mm3" || jednostka == "mm^3")
            return wartosc *= 0.000000001;
        else if (jednostka == "cm3" || jednostka == "cm^3")
            return wartosc *= 0.000001;
        else if (jednostka == "dm3" || jednostka == "dm^3" || jednostka == "" || jednostka == "")
            return wartosc *= 0.001;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double dm3(double wartosc, String jednostka)
    {
        if (jednostka == "mm3" || jednostka == "mm^3")
            return wartosc *= 0.000001;
        else if (jednostka == "cm3" || jednostka == "cm^3")
            return wartosc *= 0.001;
        else if (jednostka == "m3" || jednostka == "m^3")
            return wartosc *= 1000;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double cm3(double wartosc, String jednostka)
    {
        if (jednostka == "mm3" || jednostka == "mm^3")
            return wartosc *= 0.001;
        else if (jednostka == "dm3" || jednostka == "dm^3" || jednostka == "" || jednostka == "")
            return wartosc *= 1000;
        else if (jednostka == "m3" || jednostka == "m^3")
            return wartosc *= 1000000;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    // Przeliczniki jednostek czasu
    public static double hr(double wartosc, String jednostka)
    {
        if (jednostka == "min")
            return wartosc *= 1.0 / 60.0;
        else if (jednostka == "s" || jednostka == "sec")
            return wartosc *= 1.0 / 3600.0;
        else if (jednostka == "day")
            return wartosc *= 24.0;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double min(double wartosc, String jednostka)
    {
        if (jednostka == "hr" || jednostka == "h")
            return wartosc *= 60.0;
        else if (jednostka == "s" || jednostka == "sec")
            return wartosc *= 1.0 / 60.0;
        else if (jednostka == "day")
            return wartosc *= 1440;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double s(double wartosc, String jednostka)
    {
        if (jednostka == "hr" || jednostka == "h")
            return wartosc *= 3600;
        else if (jednostka == "min")
            return wartosc *= 60;
        else if (jednostka == "day")
            return wartosc *= 86400;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double dzien(double wartosc, String jednostka)
    {
        if (jednostka == "hr" || jednostka == "h")
            return wartosc *= 1.0 / 24.0;
        else if (jednostka == "min")
            return wartosc *= 1.0 / 1440.0;
        else if (jednostka == "s" || jednostka == "sec")
            return wartosc *= 1.0 / 86400.0;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double obr_min(double wartosc, String jednostka)
    {
        if (jednostka == "obr/s" || jednostka == "obr/sec")
            return wartosc *= 60;
        else if (jednostka == "obr/min")
            return wartosc;
        else if (jednostka == "one_s")
            return wartosc *= 2 * Math.PI/60;
        else if (jednostka == "one_min")
            return wartosc *= 2 * Math.PI;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double obr_s(double wartosc, String jednostka)
    {
        if (jednostka == "obr/s" || jednostka == "obr/sec")
            return wartosc;
        else if (jednostka == "obr/min")
            return wartosc /= 60;
        else if (jednostka == "one_s")
            return wartosc /= 2;
        else if (jednostka == "one_min")
            return wartosc /= wartosc;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }

    public static double one_min(double wartosc, String jednostka)
    {
        if (jednostka == "obr/s" || jednostka == "obr/sec")
            return wartosc;
        else if (jednostka == "obr/min")
            return wartosc /= 60;
        else if (jednostka == "one_s")
            return wartosc /= 2;
        else if (jednostka == "one_min")
            return wartosc /= wartosc;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }

    public static double one_s(double wartosc, String jednostka)
    {
        if (jednostka == "obr/s" || jednostka == "obr/sec")
            return wartosc;
        else if (jednostka == "obr/min")
            return wartosc /= 60;
        else if (jednostka == "one_s")
            return wartosc /= wartosc;
        else if (jednostka == "one_min")
            return wartosc /= 2;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }


    // Przeliczniki jednostek predkosci
    public static double km_hr(double wartosc, String jednostka)
    {
        if (jednostka == "m/s" || jednostka == "m/sec")
            return wartosc *= 3600.0 / 1000.0;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double m_s(double wartosc, String jednostka)
    {
        if (jednostka == "km/hr" || jednostka == "km/h")
            return wartosc *= 1000.0 / 3600.0;
        else if (jednostka == "m/s" || jednostka == "m/sec")
            return wartosc;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }

    // Przyspieszenie
    public static double m_s2(double wartosc, String jednostka)
    {
        if (jednostka == "m/s^2" || jednostka == "m/sec^2")
            return wartosc;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }

    // Przeliczniki jednostek strumienia objetosci
    public static double m3_s(double wartosc, String jednostka)
    {
        if (jednostka == "m3/hr" || jednostka == "m3/h" || jednostka == "m^3/hr" || jednostka == "m^3/h")
            return wartosc *= 1 / 3600.0;
        else if (jednostka == "dm3/s" || jednostka == "dm3/sec" || jednostka == "dm^3/s" || jednostka == "dm^3/sec" || jednostka == "l/s" || jednostka == "l/sec")
            return wartosc *= 1 / 1000.0;
        else if (jednostka == "dm3/hr" || jednostka == "dm3/h" || jednostka == "dm^3/hr" || jednostka == "dm^3/h" || jednostka == "l/hr" || jednostka == "l/h")
            return wartosc *= 1.0 / (1000.0 * 3600.0);
        else if (jednostka == "m^3/s")
            return wartosc;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double m3_hr(double wartosc, String jednostka)
    {
        if (jednostka == "m3/s" || jednostka == "m3/sec" || jednostka == "m^3/s" || jednostka == "m^3/sec")
            return wartosc *= 3600.0;
        else if (jednostka == "dm3/s" || jednostka == "dm3/sec" || jednostka == "dm^3/s" || jednostka == "dm^3/sec" || jednostka == "l/s" || jednostka == "l/sec")
            return wartosc *= 3600.0 / 1000.0;
        else if (jednostka == "dm3/hr" || jednostka == "dm3/h" || jednostka == "dm^3/hr" || jednostka == "dm^3/h" || jednostka == "l/hr" || jednostka == "l/h")
            return wartosc *= 1.0 / 1000.0;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double dm3_s(double wartosc, String jednostka)
    {
        if (jednostka == "m3/s" || jednostka == "m3/sec" || jednostka == "m^3/s" || jednostka == "m^3/sec")
            return wartosc *= 1000.0;
        else if (jednostka == "m3/hr" || jednostka == "m3/h" || jednostka == "m^3/hr" || jednostka == "m^3/h")
            return wartosc *= 1000.0 / 3600.0;
        else if (jednostka == "dm3/hr" || jednostka == "dm3/h" || jednostka == "dm^3/hr" || jednostka == "dm^3/h" || jednostka == "l/hr" || jednostka == "l/h")
            return wartosc *= 1.0 / 3600.0;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double dm3_hr(double wartosc, String jednostka)
    {
        if (jednostka == "m3/s" || jednostka == "m3/sec" || jednostka == "m^3/s" || jednostka == "m^3/sec")
            return wartosc *= 1000.0 * 3600.0;
        else if (jednostka == "m3/hr" || jednostka == "m3/h" || jednostka == "m^3/hr" || jednostka == "m^3/h")
            return wartosc *= 1000.0;
        else if (jednostka == "dm3/s" || jednostka == "dm3/sec" || jednostka == "dm^3/s" || jednostka == "dm^3/sec" || jednostka == "l/s" || jednostka == "l/sec")
            return wartosc *= 3600.0;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    // Przeliczniki jednostek mocy
    public static double W(double wartosc, String jednostka)
    {
        if (jednostka == "W")
            return wartosc;
        else if (jednostka == "kW")
            return wartosc *= 1000.0;
        else if (jednostka == "MW")
            return wartosc *= 1000000;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double kW(double wartosc, String jednostka)
    {
        if (jednostka == "W")
            return wartosc *= 0.001;
        else if (jednostka == "kW")
            return wartosc;
        else if (jednostka == "MW")
            return wartosc *= 1000;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double MW(double wartosc, String jednostka)
    {
        if (jednostka == "W")
            return wartosc *= 0.000001;
        else if (jednostka == "kW")
            return wartosc *= 0.001;
        else if (jednostka == "MW")
            return wartosc;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    // Przelinczniki procent
    public static double ulamek(double wartosc, String jednostka)
    {
        if (jednostka == "%")
            return wartosc *= 0.01;
        else if (jednostka == "-" || jednostka == "ulamek" || jednostka == "Ulamek")
            return wartosc;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double procent(double wartosc, String jednostka)
    {
        if (jednostka == "-" || jednostka == "ulamek" || jednostka == "Ulamek")
            return wartosc *= 100;
        else if (jednostka == "%")
            return wartosc;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    // Przeliczniki jednostek katowych
    public static double deg(double wartosc, String jednostka)
    {
        if (jednostka == "rad")
            return wartosc *= 360.0 / (2 * Math.PI);
        else if (jednostka == "deg")
            return wartosc;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    public static double rad(double wartosc, String jednostka)
    {
        if (jednostka == "deg" || jednostka == "°")
            return wartosc *= (2 * Math.PI) / 360.0;
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    /// <summary>
    /// Przelicz dana wartosc na ekwiwalent jednostki w SI
    /// </summary>
    /// <param name="wartosc">Wartosc do przeliczenia</param>
    /// <param name="jednostka">Jednostka wartosci</param>
    /// <returns></returns>
    public static double SI(double wartosc, String jednostka)
    {
        if (jednostka == "mm" || jednostka == "cm" || jednostka == "m" || jednostka == "km")
            return m(wartosc, jednostka);
        else if (jednostka == "s" || jednostka == "sec" || jednostka == "min" || jednostka == "h" || jednostka == "hr" || jednostka == "day")
            return s(wartosc, jednostka);
        else if (jednostka == "m/s" || jednostka == "m/sec" || jednostka == "km/hr" || jednostka == "km/h")
            return m_s(wartosc, jednostka);
        else if (jednostka == "m3/hr" || jednostka == "m3/h" || jednostka == "m^3/hr" || jednostka == "m^3/h" ||
                jednostka == "m3/s" || jednostka == "m3/sec" || jednostka == "m^3/s" || jednostka == "m^3/sec" ||
                jednostka == "dm3/s" || jednostka == "dm3/sec" || jednostka == "dm^3/s" || jednostka == "dm^3/sec" ||
                jednostka == "l/s" || jednostka == "l/sec" || jednostka == "dm3/hr" || jednostka == "dm3/h" ||
                jednostka == "dm^3/hr" || jednostka == "dm^3/h" || jednostka == "l/hr" || jednostka == "l/h")
            return m3_s(wartosc, jednostka);
        else if (jednostka == "W" || jednostka == "kW" || jednostka == "MW")
            return W(wartosc, jednostka);
        else if (jednostka == "m/s^2")
            return m_s2(wartosc, jednostka);
        else if (jednostka == "obr/min" || jednostka == "obr/s")
            return obr_min(wartosc, jednostka);
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostka);
    }
    /// <summary>
    /// Przelicza dana wartosc z jednej jednostki na druga
    /// </summary>
    /// <param name="wartosc">Wartosc do przeliczenia</param>
    /// <param name="jednostkaWartosci"> Jednostka wartosci</param>
    /// <param name="jednostkaDocelowa"> Jednostka docelowa</param>
    /// <returns></returns>
    public static double Przelicz(double wartosc, String jednostkaWartosci, String jednostkaDocelowa)
    {
        if (jednostkaDocelowa == "m")
            return m(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "dm")
            return dm(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "cm")
            return cm(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "mm")
            return mm(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "km/hr")
            return km_hr(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "m/s")
            return m_s(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "m^3/s")
            return m3_s(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "m^3/hr")
            return m3_hr(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "dm^3/s" || jednostkaDocelowa == "l/s")
            return dm3_s(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "dm^3/hr" || jednostkaDocelowa == "l/hr")
            return dm3_hr(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "W")
            return W(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "kW")
            return kW(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "MW")
            return MW(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "deg")
            return deg(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "rad")
            return rad(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "-" || jednostkaDocelowa == "Ulamek")
            return ulamek(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "%" || jednostkaDocelowa == "Procent")
            return procent(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "obr/min")
            return obr_min(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "obr/s")
            return obr_s(wartosc, jednostkaWartosci);
        else if (jednostkaDocelowa == "m/s^2")
            return m_s2(wartosc, jednostkaWartosci);
        else
            throw new ArgumentException("Nieznana jednostka: " + jednostkaDocelowa);
    }

    public static double RadToDeg(double wartosc)
    {
        return KJ.deg(wartosc, "rad");
    }

    public static double DegToRad(double wartosc)
    {
        return KJ.rad(wartosc, "deg");
    }

    /// <summary>
    /// Wartosc o danej jednostce zapisana z nowa jednostka w postaci tekstu
    /// </summary>
    /// <param name="wartosc">wartosc</param>
    /// <param name="jednostkaWartosci">jednostka wartosci</param>
    /// <param name="nowaJednostka">nowa jednostka</param>
    /// <param name="zakres">postac wyswietlenia tekstu</param>
    /// <returns></returns>
    public static string ToString(double wartosc, String jednostkaWartosci, String nowaJednostka, String zakres)
    {
        return (KJ.Przelicz(wartosc, jednostkaWartosci, nowaJednostka)).ToString(zakres) + " " + nowaJednostka;
    }
}

