<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="VendorAddEdit.aspx.cs" Inherits="JobTrackerAdmin.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="row">
    <div class="col-lg-6">
        <div class="panel">
            <div class="panel-heading">
			    <h3 class="panel-title">Add New Vendors</h3>
			</div>
            <div class="panel-body">
               <input type="text" class="form-control" placeholder="Vendor Name" name="VendorName" value="<% =VendorName %>">
               <input type="text" class="form-control" placeholder="Vendor Address" name="VendorAddress" value="<% =VendorAddress %>">
               <input type="text" class="form-control" placeholder="Vendor Contact Number" name="VendorContact" value="<% =VendorContact %>">
               <input type="text" class="form-control" placeholder="Vendor Email" name="VendorEmail" value="<% =VendorEmail %>">
                <input type="text" class="form-control" placeholder="Vendor PAN" name="VendorPAN" value="<% =VendorPAN %>">
               <input type="text" class="form-control" placeholder="Vendor GSTN" name="VendorGSTN" value="<% =VendorGST %>">
                <input type="text" class="form-control" placeholder="Vendor Remark" name="VendorRemarks" value="<% =VendorRemarks %>">
                <asp:Button ID="btn_Save" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btn_Save_Click" />
                <%--<button type="button" class="btn btn-primary">Save</button>--%>
				<button type="button" class="btn btn-info">Reset</button>
            </div>            
        </div>
    </div>
</div>


</asp:Content>
