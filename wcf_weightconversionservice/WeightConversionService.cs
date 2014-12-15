using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_WeightConversionService
{
    public class WeightConversionService : IWeightConversionService
    {
        public double PoundsToKilos(double pounds)
        {
            return pounds / 2.2046226218;
        }

        public double KilosToPounds(double kilos)
        {
            return kilos * 2.2046226218;
        }
    }
}
