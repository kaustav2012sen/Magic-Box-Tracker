<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Paper.aspx.cs" Inherits="JobTrackerAdmin.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
         <div class="col-lg-12">
             <div class="panel">
                  <div class="panel-heading">
			    <h3 class="panel-title">Paper List</h3>
			</div>
                 <div class="panel-body">
              <table id="PaperTable" class="table table-bordered table-striped">
                            
                <thead>
                <tr>
                  <th class="auto-style1" >Ppaer Type</th>
                  <th class="auto-style1">Paper Remarks</th>
                  <%--<th>Dummy</th>--%>
                </tr>
                </thead>
                <tbody>
                  <asp:PlaceHolder ID="DbDataPlaceholder" runat="server"></asp:PlaceHolder>
                   
                
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
         </div></div></div>
            </div>
</asp:Content>
