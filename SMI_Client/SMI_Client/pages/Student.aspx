<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="SMI_Client.pages.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">


       <div class="container-fluid">
<div class="row">
    <div class="col">
         <h1 class="text-center">All Students </h1>
    </div>

    </div>

      <div class="col align-items-center p-3" > 

      <asp:GridView ID="studentlist" runat="server"  CellPadding="4" ForeColor="#333333" GridLines="None" Width="564px">
          <Columns>
              <asp:TemplateField HeaderText = "Update">
                  <ItemTemplate>
                      <a href='<%# "updateStudent.aspx?Id=" + Eval("Student_id")  %>' class="btn btn-dark">Update</a>
                  </ItemTemplate>
              </asp:TemplateField>

                <asp:TemplateField HeaderText = "Delete">
      <ItemTemplate>
          <a href='<%# "deleteStudent.aspx?Id=" + Eval("Student_id")  %>' class="btn btn-danger">Delete</a>
      </ItemTemplate>
  </asp:TemplateField>
          </Columns>
          <AlternatingRowStyle BackColor="White" />
          <EditRowStyle BackColor="#7C6F57" />
          <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
          <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
          <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
          <RowStyle BackColor="#E3EAEB" />
          <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
          <SortedAscendingCellStyle BackColor="#F8FAFA" />
          <SortedAscendingHeaderStyle BackColor="#246B61" />
          <SortedDescendingCellStyle BackColor="#D4DFE1" />
          <SortedDescendingHeaderStyle BackColor="#15524A" />
      </asp:GridView>
  </div>

           </div>

</asp:Content>
