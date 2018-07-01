<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Vendor.aspx.cs" Inherits="JobTrackerAdmin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
         <div class="col-lg-12">
             <div class="panel">
                  <div class="panel-heading">
			    <h3 class="panel-title">Vendor List</h3>
			</div>
                 <div class="panel-body">
              <table id="VendorTable" class="table table-bordered table-striped">
                            
                <thead>
                <tr>
                  <th class="auto-style1" >Vendor Name</th>
                  <th class="auto-style1">Address</th>
                  <th class="auto-style1">Contact</th>
                  <th class="auto-style1">Email</th>
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
										<div class="col-md-6 text-right"><a href="VendorAddEdit.aspx" class="btn btn-primary">Add New Vendors</a></div>
									</div>
								</div>


             </div></div>
            </div>





</asp:Content>
