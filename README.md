BMI Calculator (VB.NET) - Setup Guide
====================================

This guide explains how to:
1. Set up the project in Visual Studio Code (VSC)
2. Build and run the application
3. Export as a standalone .exe file

---

📋 **Prerequisites**
----------------------
1. **Visual Studio Code** (Latest Version)
   - Download: https://code.visualstudio.com/
2. **.NET SDK (9.0 or later)**
   - Download: https://dotnet.microsoft.com/download
3. **VSC Extensions** (Install via Extensions Marketplace `Ctrl+Shift+X`):
   - "VSCode VB.NET" (for syntax highlighting)
   - "Code Runner" (optional, for quick execution)

---

🛠 **Project Setup in VSC**
---------------------------
1. **Clone/Create Project**
   - Open Terminal (`Ctrl+` `) and run:
     ```
     git clone [Your-Repo-URL]  # (If using Git)
     cd BMICalculator
     ```
   - **OR** Create a new project manually:
     ```
     dotnet new console -lang VB -n BMICalculator
     cd BMICalculator
     code .
     ```

2. **Update Project File**  
   Replace `BMICalculator.vbproj` with:
   ```xml
   <Project Sdk="Microsoft.NET.Sdk">
     <PropertyGroup>
       <OutputType>WinExe</OutputType>
       <TargetFramework>net9.0-windows</TargetFramework>
       <UseWindowsForms>true</UseWindowsForms>
     </PropertyGroup>
   </Project>
