﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_WeightConversionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWeightConversionService
    {
        [OperationContract]
        double PoundsToKilos(double pounds);

        [OperationContract]
        double KilosToPounds(double kilos);
    } 
}