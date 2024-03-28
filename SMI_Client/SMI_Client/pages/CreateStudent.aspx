<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.Master" AutoEventWireup="true" CodeBehind="CreateStudent.aspx.cs" Inherits="SMI_Client.pages.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

    <div class="container-fluid">
        <div class="row">

            <h1 class="text-center">Create Student </h1>


        </div>


        <div class="row">
            <div class="col-md-4">
                <div class=" mb-3">
                    <label for="" class="col-form-label text-success">Student Name</label>
                    <input type="text" placeholder="Name" autocomplete="off" class="form-control" runat="server" id="name" required />
                </div>


                <div class=" mb-3">


                    <label for="" class="col-form-label text-success">Student Email</label>
                    <input type="email" placeholder="Email" autocomplete="off" class="form-control" runat="server" id="email" required />
                </div>

                <div class=" mb-3">
                    <label for="" class="col-form-label text-success">Student Age</label>
                    <input type="number" placeholder="Age" autocomplete="off" class="form-control" runat="server" id="age" required />
                </div>
                <div class=" mb-3">
                    <label for="" class="col-form-label text-success">Student Gender </label>
                    <br />
                    <asp:DropDownList runat="server" Height="35px" Width="352px" ID="Gen">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>other</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class=" mb-3">
                    <label for="" class="col-form-label text-success">Branch</label><br />
                    <asp:DropDownList runat="server" Height="35px" Width="352px" ID="branch">
                    </asp:DropDownList>
                </div>

                <br />

                <div class="row ">


                    <div class="col d-flex">
                        <asp:Button ID="SaveBtn" runat="server" Text="Save" CssClass="btn-success btn-block btn" OnClick="SaveBtn_Click" />

                    </div>

                    <div class="col d-flex">
                        <a href="Home.aspx">Go back</a>
                    </div>
                </div>
                <br />

                <div class="row">
                    <asp:Label runat="server" ID="ErrMsg" CssClass="text-danger"></asp:Label>
                </div>


                <br />


            </div>
            <div class="col p-3">
                <img class="align-items-center p-4  mx-auto d-block" style="height: 450px" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDrOx7fR5n2Q8ipH4x_is_4mDDD3zlJCz_1dhPB2xG8tdkBu6lGL-q9bcSu7D31Wqz_l8&usqp=CAU" />
            </div>
        </div>
</asp:Content>
