<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Splash.aspx.cs" Inherits="UnitConverterApp.Splash" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to Unit Converter App</title>
    <style type="text/css">
        body {
            background-color: skyblue;
            font-family: Arial, sans-serif;
            text-align: center;
            padding-top: 100px;
        }
        .splash-container {
            background-color: white;
            display: inline-block;
            padding: 40px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0,0,0,0.3);
        }
        .logo {
            width: 142px;
            height: 129px;
        }
        .loading-text {
            margin-top: 20px;
            font-size: 18px;
            color: #333;
        }
        .progress-bar {
            width: 100%;
            background-color: #ddd;
            border-radius: 5px;
            overflow: hidden;
            margin-top: 20px;
        }
        .progress-bar-fill {
            height: 20px;
            width: 0;
            background-color: #4CAF50;
            animation: fillProgress 3s forwards;
        }
        @keyframes fillProgress {
            to { width: 100%; }
        }
    </style>
    <script type="text/javascript">
        setTimeout(function () {
            window.location.href = 'Default.aspx';
        }, 3000); // Redirects after 3 seconds
    </script>
</head>
<body>
    <div class="splash-container">
        <img src="https://e7.pngegg.com/pngimages/857/544/png-clipart-brand-material-conversion-of-units-angle-text-thumbnail.png" alt="Unit Converter Logo" class="logo" />
        <div class="loading-text">Loading Unit Converter App...</div>
        <div class="progress-bar">
            <div class="progress-bar-fill"></div>
        </div>
    </div>
</body>
</html>
