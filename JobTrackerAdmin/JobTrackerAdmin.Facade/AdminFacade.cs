﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobTrackerAdmin.DAL;
using System.Data;

namespace JobTrackerAdmin.Facade
{
    public class AdminFacade
    {

        #region Client
        ClientData clientData = new ClientData();
        
        public DataTable GetAllClientDetails()
        {
            return clientData.GetAllClients();
        }

        #endregion

    }
}