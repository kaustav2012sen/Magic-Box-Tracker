<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Job.aspx.cs" Inherits="JobTrackerAdmin.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

             <div class="row">
         <div class="col-lg-6">
             <div class="panel">
                  <div class="panel-heading">
			    <h3 class="panel-title">Job List</h3>
			</div>
                 <div class="panel-body">
              <table id="ClientTable" class="table table-bordered table-striped">
                            
                <thead>
                <tr>
                  <th class="auto-style1">Job ID</th>
                  <th class="auto-style1">Job Description</th>
                  <th class="auto-style1">Master Job</th>
                   <th class="auto-style1">Job Remarks</th>
                </tr>
                </thead>
                <tbody>
                  <asp:PlaceHolder ID="DbDataPlaceholder" runat="server"></asp:PlaceHolder>
                   
                </tbody>
                <tfoot>
                </tfoot>
              </table>
         </div>
            </div>
         </div>

             <div class="col-lg-6">
                             <div class ="panel panel-default">
            <div class="panel-heading">Job Name Entry</div>
            <div class =" panel-body">      
            <div class="form-group">
            <label for="jobDescription">Job Description</label>
               <input type="text" class="form-control" placeholder="Job Description" name="JobDescription" value="<% =JobDescription %>">
            </div>
           
            <div class="form-group">
                <label for="clinetName">Nested Description</label>
                  <asp:DropDownList ID="ddlNestedDescription" runat="server" CssClass="form-control" AutoPostBack="false">
                  <asp:ListItem Selected="True" Value="0" Text="Select Master Job"></asp:ListItem>
                  </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="remark">Remark</label>
                <input type="text" class="form-control" placeholder="Job Remarks" name="JobRemarks" value="<% =JobRemarks %>">
                <%--<asp:TextBox ID="JobDescription" runat="server" TextMode="MultiLine" CssClass="form-control" BackColor="#e1e1e1"></asp:TextBox>--%>
                </div>
                <asp:Button ID="btn_Save" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btn_Save_Click" />
				<button type="button" class="btn btn-info">Reset</button>
                
            </div>
</div>
</div>





            </div>




</asp:Content>
