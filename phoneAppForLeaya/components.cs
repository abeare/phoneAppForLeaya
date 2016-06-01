using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneAppForLeaya
{
    class components
    {
        public int Node { get; set; }
        public int resistor { get; set; }
        public int capacitor { get; set; }
        public int Iductor { get; set; }
        public int outputpositive { get; set; }
        public int outputnegative { get; set; }
        
        public object resistorValues { get; set; }
        public object resistorNPValues { get; set; }
        public object resistorNNValues { get; set; }


        public object capacitorValues { get; set; }
        public object capacitorNPValues { get; set; }
        public object capacitorNNValues { get; set; }


        public object inductorValues { get; set; }
        public object inductorNPValues { get; set; }
        public object inductorNNValues { get; set; }


    }

    public class resistorComp
    {
        public List<double> ResistorsValue { get; set; }
        public List<int> ResistorsNegativeNodes { get; set; }
        public List<int> ResistorsPositiveNodes { get; set; }

    }

    public class capacitorComp
    {
        public List<double> CapacitorsValue { get; set; }
        public List<int> CapacitorsNegativeNodes { get; set; }
        public List<int> CapacitorsPositiveNodes { get; set; }

    }

    public class inductorComp
    {
        public List<double> IductorsValue { get; set; }
        public List<int> IductorsNegativeNodes { get; set; }
        public List<int> IductorsPositiveNodes { get; set; }

    }

    public class Complexdata
    {

        public double Real
        {
            get;
            set;
        }

        public double Imaginary
        {
            get;
            set;
        }
    }
}
