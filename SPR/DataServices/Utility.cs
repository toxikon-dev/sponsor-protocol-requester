using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ToxCTS.DataServices
{
    internal class Utility
    {
        internal static string GetTPMConnectionString()
        {
            string TPM = @"Toxikon.Web.ProtocolManager.Properties.Settings.TPMConnectionString";
            string TPMTest = @"Toxikon.Web.ProtocolManager.Properties.Settings.TPMTestConnectionString";
            string result = "";
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[TPM];
            if (settings != null)
            {
                result = settings.ConnectionString;
            }
            return result;
        }

        internal static string GetMatrixConnectionString()
        {
            string LIMS = @"SPR.Properties.Settings.LIMSConnectionString";
            string result = "";
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[LIMS];
            if (settings != null)
            {
                result = settings.ConnectionString;
            }
            return result;
        } 
        internal static string GetSPRConnectionString()
        {
            string SPR = @"SPR.Properties.Settings.SPRConnectionString";
            string result = "";
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[SPR];
            if (settings != null)
            {
                result = settings.ConnectionString;
            }
            return result;
        }
    }
}