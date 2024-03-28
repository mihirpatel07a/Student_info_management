<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SMI_Client.pages.Home1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

    <header class="jumbotron bg-info text-white text-center p-4 my-2">
        <div class="container">
            <h1 class="display-4">Welcome to Student Management System</h1>
            <p class="lead">Manage students, courses, and more.</p>
        </div>
    </header>

    <!-- Main Content Section -->
    <div class="container mt-4">
        <div class="row">
            <div class="col-md-4">
                <!-- Card for displaying student information -->
                <div class="card">
                    <div class="card-header">
                        Student Info
                    </div>
                    <div class="card-body">
                        <h5 class="card-title">Total Students</h5>
                        <p class="card-title">
                            <asp:Label ID="Label3" runat="server"></asp:Label>
                        </p>


                        <!-- Add more student information fields as needed -->
                        <a href="Student.aspx" class="btn btn-dark">View Details</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4">

                <div class="card">
                    <div class="card-header">
                        Branch Info
                    </div>
                    <div class="card-body">
                        <h5 class="card-title">Total Branches</h5>
                        <p class="card-title">
                            <asp:Label ID="Label4" runat="server"></asp:Label>
                        </p>


                        <!-- Add more student information fields as needed -->
                        <a href="Branch.aspx" class="btn btn-dark">View Details</a>
                    </div>
                </div>
            </div>
            <!-- Add more card columns for displaying additional students -->
        </div>
    </div>
</asp:Content>
