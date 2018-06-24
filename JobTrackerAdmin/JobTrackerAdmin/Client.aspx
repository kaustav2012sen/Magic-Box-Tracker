<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="JobTrackerAdmin.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="box-body">
              <table id="ClientTable" class="table table-bordered table-striped">
                            
                <thead>
                <tr>
                  <th class="auto-style1" >Client Name</a></th>
                  <th class="auto-style1">Address</th>
                  <th class="auto-style1">Contact</th>
                  <th class="auto-style1">GST</th>
                    <th class="auto-style1">PAN</th>
                  <th class="auto-style1">Remarks</th>
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
            </div>
</asp:Content>
