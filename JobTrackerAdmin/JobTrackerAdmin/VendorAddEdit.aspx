<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="VendorAddEdit.aspx.cs" Inherits="JobTrackerAdmin.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="row">
    <div class="col-lg-6">
        <div class="panel">
            <div class="panel-heading">
			    <h3 class="panel-title">Add New Vendors</h3>
			</div>
            <div class="panel-body">
               <input type="text" class="form-control" placeholder="Vendor Name">
               <input type="text" class="form-control" placeholder="Vendor Address">
               <input type="text" class="form-control" placeholder="Vendor Contact Number">
               <input type="text" class="form-control" placeholder="Vendor Email">
               <input type="text" class="form-control" placeholder="Vendor GSTN">
                <input type="text" class="form-control" placeholder="Vendor PAN">
                <input type="text" class="form-control" placeholder="Vendor Remark">
                <button type="button" class="btn btn-primary">Save</button>
				<button type="button" class="btn btn-info">Reset</button>
            </div>            
        </div>
    </div>
</div>


</asp:Content>
