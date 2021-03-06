﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="DigitalJobCardEntry.aspx.cs" Inherits="JobTrackerAdmin.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script src="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.9.0/fullcalendar.min.js"></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.9.0/fullcalendar.print.css"   />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.9.0/fullcalendar.min.css" />
<%--<script src="Scripts/toastr.min.js"></script>

<link href="content/toastr.min.css" rel="stylesheet" />--%>
<script src="http://code.jquery.com/jquery-1.9.1.min.js" type="text/javascript"></script>
<Link href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/2.0.1/css/toastr.css" rel="stylesheet" />
<script src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/2.0.1/js/toastr.js" type="text/javascript"></script>
    <div class="row">
        <div class="col-lg-4">
            <div class ="panel panel-default">
            <div class="panel-heading">Digital Job Card Entry</div>
            <div class =" panel-body">      
            <div class="form-group">
            <label for="jobDate">Job Date</label>
            <input type="date" class="form-control" id="jobDate" placeholder="Job Date">
            </div>
            <div class="form-group">
                <label for="jobCardNo">Job Card No.</label>
                <input type="text" class="form-control" id="jobCardNo" placeholder="Job Card No." value="<%=JobCardID %>" readonly>
                </div>
          <div class="form-group">
                <label for="clinetName">Client Name</label>
                <%--<input type="text" class="form-control" id="clientName" placeholder="Client Name">--%>
              <asp:DropDownList ID="ddlClient" runat="server" CssClass="form-control">
               <asp:ListItem Selected="True" Value="0" Text="-----Select------"></asp:ListItem>
                  
                  </asp:DropDownList>
                </div>
                    <div class="form-group">
                <label for="printer">Printer Name</label>
                <%--<input type="text" class="form-control" id="printer" placeholder="Printer Name">--%>
              <asp:DropDownList ID="ddlPrinter" runat="server" CssClass="form-control">
               <asp:ListItem Selected="True" Value="0" Text="-----Select------"></asp:ListItem>

              </asp:DropDownList>

                </div>
                 <div class="form-group">
                <label for="printer">Paper Name</label>
                <%--<input type="text" class="form-control" id="printer" placeholder="Printer Name">--%>
              <asp:DropDownList ID="ddlPaper" runat="server" CssClass="form-control">
               <asp:ListItem Selected="True" Value="0" Text="-----Select------"></asp:ListItem>

              </asp:DropDownList>

                </div>
                    <div class="form-group">
                <label for="paperQty">Paper Qty</label>
                <input type="number" class="form-control" id="paperQty" placeholder="Paper Qty" name="paperQty" value="<%=PaperQty %>">
                </div>
                    <div class="form-group">
                <label for="printQty">Print Qty</label>
                <input type="text" class="form-control" id="printQty" placeholder="Print Qty" name="printQty" value="<%=PrintQty %>">
                </div>
          <div class="form-group">
                <label for="remark">Remark</label>
              <asp:TextBox ID="JobDescription" runat="server" TextMode="MultiLine" CssClass="form-control" BackColor="#e1e1e1"></asp:TextBox>
               <%--<textarea class="form-control" rows="5" name="DigitalRemarks" value="<%=Remarks %>"></textarea>--%>
                </div>

           <%--<button type="button" class="btn btn-primary">Save</button>--%>
                <asp:Button ID="btn_SaveJob" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btn_SaveJob_Click" />
				<button type="button" class="btn btn-info">Reset</button>


          </div>
</div>
        </div>

        <div class="col-lg-8">
            <div class=" panel panel-default">
                <div class="panel-heading">Digital Jobs . Dated :- "TODAY"</div>
                <div class="panel-body">
                    <table id="digitalJobs" class="table table-bordered table-striped">
                                        <thead>
                <tr>
                  <th class="auto-style1" >Job Card No.</th>
                  <th class="auto-style1">Client Name</th>
                  <th class="auto-style1">Printer Name</th>
                  <th class="auto-style1">Paper Type</th>
                  <th class="auto-style1">Print Qty</th>
                  <th class="auto-style1">Paper Qty</th>
                  <th class="auto-style1">Remark</th>                
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
     
    </div>

</asp:Content>
