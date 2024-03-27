<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SMI_Client.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Content/bootstrap.min.css" />
    <style>
        body {
            background-image: url('https://img.freepik.com/free-photo/abstract-digital-grid-black-background_53876-97647.jpg'); /* Replace 'path_to_your_image.jpg' with the actual path to your image */
            background-size: cover;
            background-repeat: no-repeat;
            background-position: center;
        }
    </style>
</head>
<body>
    <div class="container-fluid">
        <div class="row"></div>
        <div class="row justify-content-center p-4">
            <div class="col-md-4">
                <form id="form1" class="align-items-center" runat="server">
                    <div class="mt-3" style="display: flex; justify-content: center;">
                        <img id="Image1" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQjCGHGLdIwk3g0WoC6OgoagMuFedUJ2rSLtKwuhOTGxZX2zUmNzv3WOEj2RZxTiAmfNSA&usqp=CAU" />
                    </div>
                    <div class="mt-3">
                        <label for="" class="col-form-label" style="color:white">Email<asp:Image ID="Image2" runat="server" /></label>
                        <input type="email" placeholder="enter your email" autocomplete="off" class="form-control" runat="server" id="U_name" />
                    </div>
                    <div class="mt-3">
                        <label for="" class="form-check-label" style="color:white">Password </label>
                        <input type="password" placeholder="Password" autocomplete="off" class="form-control" runat="server" id="Password" />
                    </div>
                    <div class="mt-3 d-grid">
                        <asp:Button runat="server" CssClass="btn-success" Text="Login" ID="loginbtn" OnClick="loginbtn_Click" />
                    </div>
                    <div class="row p-3">
                        <asp:Label runat="server" ID="ErrMsg" CssClass="text-danger"></asp:Label>
                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
