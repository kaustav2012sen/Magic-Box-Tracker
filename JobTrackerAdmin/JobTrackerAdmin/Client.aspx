﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="JobTrackerAdmin.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="row">
         <div class="col-lg-12">
             <div class="panel">
                  <div class="panel-heading">
			    <h3 class="panel-title">Clients List</h3>
			</div>
                 <div class="panel-body">
              <table id="ClientTable" class="table table-bordered table-striped">
                            
                <thead>
                <tr>
                  <th class="auto-style1" >Client Name</th>
                  <th class="auto-style1">Address</th>
                  <th class="auto-style1">Contact</th>
                  <th class="auto-style1">PAN</th>
                  <th class="auto-style1">GST</th>
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
                 	<div class="panel-footer">
									<div class="row">
										<div class="col-md-6">
                                            <button type="button" class="btn btn-primary btn-xs">First Page</button>
                                            <button type="button" class="btn btn-primary btn-xs"><< 10 Records</button>
                                            <button type="button" class="btn btn-primary btn-xs">10 Records >></button>
                                            <button type="button" class="btn btn-primary btn-xs">Last Page</button>
                                            <button type="button" class="btn btn-primary btn-xs">Export To Excel</button>
										</div>
										<div class="col-md-6 text-right"><a href="ClientAddEdit.aspx" class="btn btn-primary">Add New Clients</a></div>
									</div>
								</div>


             </div></div>
            </div>
</asp:Content>
