'------------------------------------------------------------
'-                File Name : Form1.frm                     - 
'-                Part of Project: Assign5                  -
'------------------------------------------------------------
'-                Written By: Nathan Gaffney                -
'-                Written On: 17 Feb 2020                   -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main program driver. The file wil -
'- load and process a text file to create a list of         -
'- clsEmployeeSale                                          -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program will accept a file path of a text file,     -
'- load the text file, and display some information about   -
'- an employees sales to the console.                       -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- (None)                                                   -
'------------------------------------------------------------
Module modMain
    '------------------------------------------------------------
    '-                Subprogram Name: Main                     -
    '------------------------------------------------------------
    '-                Written By: Nathan Gaffney                -
    '-                Written On: 17 Feb 2020                   -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is the program driver, it is intended to -
    '- load a call the subprograms needed to pull information   -
    '- from a user supplied text file and then call             -
    '- the subprograms needed to display the data               -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- None                                                     -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub Main()
        loadFile()
        readData()
        writeHeader()
        writeEmployeeInfo()
        writeHeader()
    End Sub

    Private Sub writeEmployeeInfo()
        Throw New NotImplementedException()
    End Sub

    Private Sub writeHeader()
        Throw New NotImplementedException()
    End Sub

    Private Sub readData()
        Throw New NotImplementedException()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: loadFile                 -
    '------------------------------------------------------------
    '-                Written By: Nathan Gaffney                -
    '-                Written On: 17 Feb 2020                   -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine will attempt to read the supplied file   -
    '-from the user, if the file does not exist it will         -
    '-alert the user-
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- None                                                     -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub loadFile()
        Throw New NotImplementedException()
    End Sub
End Module
