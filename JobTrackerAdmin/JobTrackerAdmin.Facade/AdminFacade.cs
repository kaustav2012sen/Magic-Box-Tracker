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
        public DataTable GetVendorDetailByID(int VendorID)
        {
            return vendorData.GetVendorDetailByID(VendorID);
        }

        public int SaveVendorData(Instance oInstance)
        {
            return vendorData.SaveVendorDetails(oInstance);
        }

        public int SaveVendorData(string VendorName, string VendorAddress, double VendorContact, string VendorEmail, string VendorPAN, string VendorGST, string VendorRemarks)
        {
            return vendorData.SaveVendorDetails(VendorName, VendorAddress, VendorContact, VendorEmail, VendorPAN, VendorGST, VendorRemarks);
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

        #region JobCard-Digital

        DigitalJobDetails digitaldetails = new DigitalJobDetails();
        public DataSet GetAllDigitalJobDetails()
        {
            return digitaldetails.GetAllDigitalJobDetails();
        }
        #endregion

        #region Job
        JobData jobData = new JobData();

        public DataTable GetAllJobDetails()
        {
            return jobData.GetAllJob();
        }
        public DataTable GetJobDetailByID(int JobID)
        {
            return jobData.GetJobDetailByID(JobID);
        }

        public int SaveJobData(Instance oInstance)
        {
            return jobData.SaveJobDetails(oInstance);
        }
        #endregion

    }
}