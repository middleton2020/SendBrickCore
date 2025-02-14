using CM.SendBrick.Interfaces.Tools;
using CM.SendBrickCore.Interfaces;
using CM.SendBrickCore.Interfaces.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.Tools
{
    public class ConnectionParameters: IConnectionParameters
    {
        public ConnectionParameters(ISetControlTools inpSetControlTools)
        {

        }
        public ConnectionParameters(IConfigurationFile inpConfigFile)
        {
        }
    }
}
