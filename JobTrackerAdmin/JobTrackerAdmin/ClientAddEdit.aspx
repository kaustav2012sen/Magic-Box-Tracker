<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="ClientAddEdit.aspx.cs" Inherits="JobTrackerAdmin.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
    <div class="col-lg-6">
        <div class="panel">
            <div class="panel-heading">
			    <h3 class="panel-title">Add New Clients</h3>
			</div>
            <div class="panel-body">
               <input type="text" class="form-control" placeholder="Client Name">
               <input type="text" class="form-control" placeholder="Client Address">
               <input type="text" class="form-control" placeholder="Client Contact Number">
               <input type="text" class="form-control" placeholder="Client GSTN">
                <input type="text" class="form-control" placeholder="Client PAN">
                <input type="text" class="form-control" placeholder="Client Remark">
                <button type="button" class="btn btn-primary">Save</button>
				<button type="button" class="btn btn-info">Reset</button>
            </div>            
        </div>
    </div>
</div>
</asp:Content>
