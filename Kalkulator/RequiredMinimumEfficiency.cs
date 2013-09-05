using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace Kalkulator
{
    // All equations are using SI units convention
    public static class RequiredMinimumEfficiency
    {
        static Dictionary<String, Dictionary<String, Dictionary<String, double>>> constantC = new Dictionary<String, Dictionary<String, Dictionary<String, double>>>();

        public static Dictionary<String, Dictionary<String, Dictionary<String, double>>> ConstantC
        {
            get { return RequiredMinimumEfficiency.constantC; }
            set { RequiredMinimumEfficiency.constantC = value; }
        }

        static RequiredMinimumEfficiency()
        {
            LoadConstantC();
        }

        private static void LoadConstantC()
        {
            String text = Kalkulator.Properties.Resources.ConstantC;
            String[] splittedText = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            String[] splittedLine;
            for(int j=1;j< splittedText.Length; j++)
            {
                splittedLine = splittedText[j].Split(' ');
                double MEI = 0.1;
                for (int i = 0; i < splittedLine.Length; i++)
                {
                    
                    if (i == 0 )
                    {
                        if(!constantC.ContainsKey(splittedLine[0]))
                            constantC.Add(splittedLine[0], new Dictionary<String, Dictionary<String, double>>());
                    }
                    else if (i == 1)
                    {
                        constantC[splittedLine[0]].Add(splittedLine[1], new Dictionary<String, double>());
                    }
                    else
                    {
                        String t = MEI.ToString("0.0");
                        constantC[splittedLine[0]][splittedLine[1]].Add(MEI.ToString("0.0"), double.Parse(splittedLine[i]));
                        MEI += 0.1;
                    }
                }
            }
        }
    
        
        /// <summary>
        /// Specific speed [1/min]
        /// </summary>
        public static double SpecificSpeedCalc(double rotationalSpeed, double flow, double head,int numberOfStages)
        {
            return rotationalSpeed * (Math.Sqrt(flow)) / (Math.Pow(head / numberOfStages, 3.0 / 4.0));
        }



        private static double xCalc(double specificSpeed)
        {
            return Math.Log(specificSpeed, Math.E);
        }

        private static double yCalc(double flow)
        {
            return Math.Log(3600*flow, Math.E);;
        }

        /// <summary>
        /// Required minimum efficiency at best efficiency point [%]
        /// </summary>
        public static double MinimumEfficiency(double flow, double head, double rotationalSpeed, String pompType, String MEI, int numberOfStages)
        {
            double x = xCalc(SpecificSpeedCalc(rotationalSpeed, flow, head, numberOfStages));
            double y = yCalc(flow);
            double c = constantC[pompType][rotationalSpeed.ToString()][MEI];
            return 88.59*x+13.46*y-11.48*Math.Pow(x,2)-0.85*Math.Pow(y,2)-0.38*x*y-c;
        }

        public static double MinimumEfficiency(double flow, double head, double rotationalSpeed, double constC, int numberOfStages)
        {
            double x = xCalc(SpecificSpeedCalc(rotationalSpeed, flow, head, numberOfStages));
            double y = yCalc(flow);
            double c = constC;
            return 88.59 * x + 13.46 * y - 11.48 * Math.Pow(x, 2) - 0.85 * Math.Pow(y, 2) - 0.38 * x * y - c;
        }

        public static double MinimumEfficiency(double flow, double constC, double specificSpeed)
        {
            double x = xCalc(specificSpeed);
            double y = yCalc(flow);
            double c = constC;
            return 88.59 * x + 13.46 * y - 11.48 * Math.Pow(x, 2) - 0.85 * Math.Pow(y, 2) - 0.38 * x * y - c;
        }

        public static double MinimumEfficiency(String pompType, double flow, double specificSpeed, double rotationalSpeed, String MEI)
        {
            double x = xCalc(specificSpeed);
            double y = yCalc(flow);
            double c = constantC[pompType][rotationalSpeed.ToString()][MEI];
            return 88.59 * x + 13.46 * y - 11.48 * Math.Pow(x, 2) - 0.85 * Math.Pow(y, 2) - 0.38 * x * y - c;
        }
    }
}
