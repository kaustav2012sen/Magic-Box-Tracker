using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobTrackerAdmin.DAL;
using JobTrackerAdmin.BO;
using System.Data;

namespace JobTrackerAdmin.Facade
{
    public class AdminFacade
    {
        Instance oInstance = new Instance();

        #region Client
        ClientData clientData = new ClientData();
        
        public DataTable GetAllClientDetails()
        {
            return clientData.GetAllClients();
        }
        public DataTable GetClientDetailByID(int CLientID)
        {
            return clientData.GetClientDetailByID(CLientID);
        }

        public int SaveClientData(Instance oInstance)
        {
            return clientData.SaveClientDetails(oInstance);
        }

        public int SaveClientData(string ClientName, string ClientAddress, double ClientContact, string ClientGST, string ClientPAN, string ClientRemarks)
        {
            return clientData.SaveClientDetails(ClientName, ClientAddress, ClientContact, ClientGST, ClientPAN, ClientRemarks);
        }

        #endregion

        #region Vendor
        VendorData vendorData = new VendorData();

        public DataTable GetAllVendorDetails()
        {
            return vendorData.GetAllVendors();
        }

        #endregion

        #region Paper
        PaperData paperData = new PaperData();

        public DataTable GetAllPaperDetails()
        {
            return paperData.GetAllPapers();
        }

        #endregion

        #region Media
        MediaData MediaData = new MediaData();

        public DataTable GetAllMediaDetails()
        {
            return MediaData.GetAllMedias();
        }

        #endregion

    }
}