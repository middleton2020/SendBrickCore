using CM.SendBrick.Interfaces.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CM.SendBrickCore.Core
{
    /// <summary>
    /// Get configuration details.
    /// </summary>
    public class SetControlTools
    {
        // This is the top level of our system, which sets up the DependencyInversions to be used by the other classes.
        #region VariableDefinitions
        private IConfigurationFile configFile;
        #endregion

        #region GetControllerObjects
        /// <summary>
        /// Get the right configuration file handler object.
        /// </summary>
        /// <returns>Configuration file handler matching IConfigurationFile.</returns>
        public IConfigurationFile GetConfigFile()
        {
            return configFile;
        }

        #endregion  // GetControllerObjects
    }
}
