<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="MediaAddEdit.aspx.cs" Inherits="JobTrackerAdmin.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row">
    <div class="col-lg-6">
        <div class="panel">
            <div class="panel-heading">
			    <h3 class="panel-title">Add New Media</h3>
			</div>
            <div class="panel-body">
               <input type="text" class="form-control" placeholder="Media Type">
               <input type="text" class="form-control" placeholder="Media Remark">
                <button type="button" class="btn btn-primary">Save</button>
				<button type="button" class="btn btn-info">Reset</button>
            </div>            
        </div>
    </div>
</div>
</asp:Content>
