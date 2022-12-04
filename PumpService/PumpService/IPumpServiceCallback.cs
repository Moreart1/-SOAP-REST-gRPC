using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PumpService
{
    public interface IPumpServiceCallback
    {
        [OperationContract]
        void UpdateStatistics(StatisticsService statistics);
    }
}
