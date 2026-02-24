<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeePage.aspx.cs" Inherits="AssessmentDotNet.Pages.EmployeePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee BioData</title>
</head>
<body>
    <form id="employeeListForm" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                 <Columns>
                    <asp:BoundField DataField="employee_no" HeaderText="Employee No" />
                    <asp:BoundField DataField="employee_name" HeaderText="Employee Name" />
                    <asp:BoundField DataField="birth_date" HeaderText="Birth Date" 
                     DataFormatString="{0:dd-MMM-yyyy}" HtmlEncode="false" />
                </Columns>
            </asp:GridView>
        </div>

    </form>
</body>
</html>
