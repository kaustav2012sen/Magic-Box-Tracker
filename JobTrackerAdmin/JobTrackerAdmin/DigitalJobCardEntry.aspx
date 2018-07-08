<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="DigitalJobCardEntry.aspx.cs" Inherits="JobTrackerAdmin.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script src="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.9.0/fullcalendar.min.js"></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.9.0/fullcalendar.print.css"   />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.9.0/fullcalendar.min.css" />



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
                <input type="text" class="form-control" id="jobCardNo" placeholder="Job Card No.">
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
              <asp:DropDownList ID="ddlPrinter" runat="server" CssClass="form-control"></asp:DropDownList>

                </div>
                    <div class="form-group">
                <label for="paperQty">Paper Qty</label>
                <input type="number" class="form-control" id="paperQty" placeholder="Paper Qty">
                </div>
                    <div class="form-group">
                <label for="printQty">Print Qty</label>
                <input type="text" class="form-control" id="printQty" placeholder="Print Qty">
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

        <div class="col-lg-8">
            <div class=" panel panel-default">
                <div class="panel-heading">Digital Jobs . Dated :- "TODAY"</div>
                <div class="panel-body">
                    <table id="digitalJobs" class="table table-bordered table-striped">
                                        <thead>
                <tr>
                  <th class="auto-style1" >Job Card No.</th>
                  <th class="auto-style1">Client Name</th>
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
