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
    Enum enuConstructor
        strFirstName
        strLastName
        intOrderID
        intID
        sngGamesSales
        intGamesQuantity
        sngDollsSales
        intDollsQuantity
        sngBuildingSales
        intBuildingQuantity
        sngModelSales
        intModelQuantity

    End Enum
    Dim lstEmployeeList As List(Of clsEmployeeSale)
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
        loadFile("ToyOrder.txt")
        writeHeader()
        writeEmployeeInfo()
        writeHeader()
    End Sub

    Private Sub writeEmployeeInfo()
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
    '- filePath - provides the file path                        -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub loadFile(ByVal filePath As String)
        Dim objMyStreamReader As System.IO.StreamReader
        Dim strLineContents As String
        objMyStreamReader = System.IO.File.OpenText(filePath)
        While Not (objMyStreamReader.EndOfStream)
            strLineContents = objMyStreamReader.ReadLine()
            Dim strContents() As String = Split(strLineContents, vbTab)
            lstEmployeeList.Add(New clsEmployeeSale(strContents(enuConstructor.strFirstName),
                                                strContents(enuConstructor.strLastName),
                                                strContents(enuConstructor.intOrderID),
                                                strContents(enuConstructor.intID),
                                                strContents(enuConstructor.sngGamesSales),
                                                strContents(enuConstructor.intGamesQuantity),
                                                strContents(enuConstructor.sngDollsSales),
                                                strContents(enuConstructor.intDollsQuantity),
                                                strContents(enuConstructor.sngBuildingSales),
                                                strContents(enuConstructor.intBuildingQuantity),
                                                strContents(enuConstructor.sngModelSales),
                                                strContents(enuConstructor.intModelQuantity)))
        End While
        objMyStreamReader.Close()
    End Sub
End Module
