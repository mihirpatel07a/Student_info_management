<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.Master" AutoEventWireup="true" CodeBehind="CreateBranch.aspx.cs" Inherits="SMI_Client.pages.CreateBranch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

           <div class="container-fluid">
    <div class="row">
        
             <h1 class="text-center"> Create Branch </h1>
       

    </div>


    <div class="row">
        <div class="col-md-4">
            <div class =" mb-3">
                   <label for=""  class="col-form-label text-success">Branch Name</label>
                      <input type ="text" placeholder="Name" autocomplete="off" class="form-control" runat="server" id="name"/>
            </div>


            <div class =" mb-3">


       <label for=""  class="col-form-label text-success">Branch Location</label>
          <input type ="text" placeholder="Location" autocomplete="off" class="form-control" runat="server" id="location"/>
</div>

        <div class =" mb-3">
        <label for=""  class="col-form-label text-success">Branch HOD</label>
          <input type ="text" placeholder="Hod" autocomplete="off" class="form-control" runat="server" id="HOD"/>
</div>

                    <div class =" mb-3">
        <label for=""  class="col-form-label text-success">N_Faculty</label>
          <input type ="number" placeholder="No_of_faculty" autocomplete="off" class="form-control" runat="server" id="faculty"/>
</div>
            
             
            <br />
             
            <div class="row ">
              
               
           <div class="col d-flex">
      <asp:Button ID="SaveBtn" runat="server" Text="Save"  CssClass="btn-success btn-block btn" OnClick="SaveBtn_Click"   />
                   
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
        <div class="col p-3">
            <img class="align-items-center p-4  mx-auto d-block" style="height: 450px" src="https://img.freepik.com/premium-vector/young-student-programmer-writing-code-computer_316839-1930.jpg?w=2000" /></div>
    </div>
               </div>
</asp:Content>
