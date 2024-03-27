<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.Master" AutoEventWireup="true" CodeBehind="updateStudent.aspx.cs" Inherits="SMI_Client.updateStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

    
       <div class="container-fluid">
    <div class="row">
        <div class="col">
             <h1 class="text-center"> Update Student </h1>
        </div>

    </div>
    <div class="row">
        <div class="col-md-4">
            <div class =" mb-3">
                   <label for=""  class="col-form-label text-success">Student Name</label>
                      <input type ="text" placeholder="Name" autocomplete="off" class="form-control" runat="server" id="name"/>
            </div>


            <div class =" mb-3">


       <label for=""  class="col-form-label text-success">Student Email</label>
          <input type ="email" placeholder="Email" autocomplete="off" class="form-control" runat="server" id="email"/>
</div>

        <div class =" mb-3
        <label for=""  class="col-form-label text-success">Student Age</label>
          <input type ="number" placeholder="Age" autocomplete="off" class="form-control" runat="server" id="age"/>
</div>
              <div class =" mb-3">
                   <label for=""  class="col-form-label text-success">Student Gender </label><br />
                    <asp:DropDownList  runat="server" Height="35px" Width="384px" id="Gen">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>other</asp:ListItem>
                   </asp:DropDownList>
            </div>
              <div class =" mb-3">
                   <label for=""  class="col-form-label text-success">Branch</label><br />
                  <asp:DropDownList  runat="server"  Height="35px" Width="384px" id="branch" >
                      <asp:ListItem>CE</asp:ListItem>
                      <asp:ListItem>IT</asp:ListItem>
                      <asp:ListItem>CH</asp:ListItem>
                      <asp:ListItem>EC</asp:ListItem>
                

                  </asp:DropDownList>
            </div>
           
            <br />
             
            <div class="row ">
              
               
           <div class="col d-flex">
      <asp:Button ID="SaveBtn" runat="server" Text="Save"  CssClass="btn-success btn-block btn"    />
                   
</div>

                           <div class="col d-flex">
      <a href="Home.aspx">Go back</a>        
</div>
            </div>
            <br />

            <div class ="row">
                   <asp:Label runat="server" ID="ErrMsg" CssClass="text-danger" ></asp:Label>
            </div>


            <br />
            
           
            </div>
          
        </div>
    </div>
</div>
</asp:Content>
