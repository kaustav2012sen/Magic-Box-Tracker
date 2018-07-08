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
                  <th class="auto-style1">Job Description</th>
                  <th class="auto-style1">Nested Description</th>
                  <%--<th>Dummy</th>--%>
                </tr>
                </thead>
                <tbody>
                 <%-- <asp:PlaceHolder ID="DbDataPlaceholder" runat="server"></asp:PlaceHolder>--%>
                   
                 <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="true"
                       DataTextField="Master Job" DataValueField="0"></asp:DropDownList>
                </tbody>
                <tfoot>
                <%--<tr>
                  <th>Rendering engine</th>
                  <th>Browser</th>
                  <th>Platform(s)</th>
                  <th>Engine version</th>
                  <%--<th>CSS grade</th>
                </tr>--%>
                </tfoot>
              </table>
         </div>
                 	<div class="panel-footer">									
                                            <button type="button" class="btn btn-primary btn-xs">First Page</button>
                                            <button type="button" class="btn btn-primary btn-xs"><< 10 Records</button>
                                            <button type="button" class="btn btn-primary btn-xs">10 Records >></button>
                                            <button type="button" class="btn btn-primary btn-xs">Last Page</button>
                                            <button type="button" class="btn btn-primary btn-xs">Export To Excel</button>
										</div>
										
							

             </div>

         </div>


             <div class="col-lg-6">
                             <div class ="panel panel-default">
            <div class="panel-heading">Job Name Entry</div>
            <div class =" panel-body">      
            <div class="form-group">
            <label for="jobDate">Job Description</label>
            <input type="text" class="form-control" id="jobDate" placeholder="Job Description">
            </div>
           
          <div class="form-group">
                <label for="clinetName">Nested Description</label>
                <%--<input type="text" class="form-control" id="clientName" placeholder="Client Name">--%>
              <asp:DropDownList ID="ddlNestedDescription" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
          <div class="form-group">
                <label for="remark">Remark</label>
               <textarea class="form-control" rows="5"></textarea>
                </div>

           <button type="button" class="btn btn-primary">Save</button>
				<button type="button" class="btn btn-info">Reset</button>
                
          </div>
</div>
             </div>





            </div>




</asp:Content>
