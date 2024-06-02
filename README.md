Overview

The XML Validator is a console application that validates XML strings passed as command-line arguments. It checks if the provided XML string is well-formed, meaning that each starting element has a corresponding ending element, and the elements are properly nested. The application outputs Valid if the XML is well-formed and Invalid otherwise.

Features

    Validates if the XML string has matching opening and closing tags.
    Ensures that elements are well nested.
    Handles invalid inputs gracefully with appropriate error messages.
    Outputs Valid or Invalid based on the input XML string.

Getting Started

  Clone the Repository by :
    git clone <repository-url>
    cd BoostDraftCodingAssignment

Build the Project

    Open the solution file BoostDraftCodingAssignment.sln in Visual Studio 2022.
    Build the solution by selecting Build > Build Solution from the menu.

Publish the Executable

    Right-click on the XmlValidator project in Solution Explorer.
    Select Publish.
    Choose Folder as the target and click Create Profile.
    Click Publish. The executable checker.exe will be created in the specified publish folder.

Usage

Open a command prompt and navigate to the directory where XmlValidator.dll is located. Use the following command to run the executable with an XML string as an argument.

XmlValidator.dll "<Design>"
