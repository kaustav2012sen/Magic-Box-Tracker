<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="DigitalJobCardEntry.aspx.cs" Inherits="JobTrackerAdmin.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
    <div class="row">
        <div class='col-sm-6'>
            <div class="form-group">
                <div class='input-group date' id='datetimepicker1'>
                    <input type='text' class="form-control" />
                    <span class="input-group-addon">
                        <span class="glyphicon glyphicon-calendar"></span>
                    </span>
                </div>
            </div>
        </div>
        <script type="text/javascript">
            $(function () {
                $('#datetimepicker1').datetimepicker();
            });
        </script>
    </div>
</div>

</asp:Content>
