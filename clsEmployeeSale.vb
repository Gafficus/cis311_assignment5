'------------------------------------------------------------
'-                File Name : clsEmployeeSale.vb            - 
'-                Part of Project: Assign5                  -
'------------------------------------------------------------
'-                Written By:Nathan Gaffne                  -
'-                Written On:17/Feb/2020                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the class definition of the           -
'- clsEmployeeSale defintion. This will hold information    -
'- regarding a single employees sale of games, dolls,       -
'- buildings, models, and the total                         -
'- This is not a properly designed class!                   -
'- All attributes will be public                            -
'------------------------------------------------------------	
Public Class clsEmployeeSale
    Public strFirstName As String
    Public strLastName As String
    Public intOrderID As Integer
    Public intID As Integer
    Public sngGamesSales As Single
    Public intGamesQuantity As Integer
    Public sngDollsSales As Single
    Public intDollsQuantity As Integer
    Public sngBuildingSales As Single
    Public intBuildingQuantity As Integer
    Public sngModelSales As Single
    Public intModelQuantity As Single
    Public sngTotalSales As Single
    '------------------------------------------------------------
    '-                Subprogram Name: btnQuit_Click            -
    '------------------------------------------------------------
    '-                Written By: Your Name                     -
    '-                Written On: The date you wrote it         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- quit button.  The program will prompt if the user really –
    '- wants to quit, and if the user clicks Yes, the program   -
    '- will terminate.  If the user click No, the program will  -
    '- continue to run.                                         –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(strFirstName As String, strLastName As String, intOrderID As Integer,
                   intID As Integer, sngGamesSales As Single, intGamesQuantity As Integer,
                   sngDollsSales As Single, intDollsQuantity As Integer, sngBuildingSales As Single,
                   intBuildingQuantity As Integer, sngModelSales As Single, intModelQuantity As Single)
        If strFirstName Is Nothing Then
            Throw New ArgumentNullException(NameOf(strFirstName))
        End If

        If strLastName Is Nothing Then
            Throw New ArgumentNullException(NameOf(strLastName))
        End If

        Me.strFirstName = strFirstName
        Me.strLastName = strLastName
        Me.intOrderID = intOrderID
        Me.intID = intID
        Me.sngGamesSales = sngGamesSales
        Me.intGamesQuantity = intGamesQuantity
        Me.sngDollsSales = sngDollsSales
        Me.intDollsQuantity = intDollsQuantity
        Me.sngBuildingSales = sngBuildingSales
        Me.intBuildingQuantity = intBuildingQuantity
        Me.sngModelSales = sngModelSales
        Me.intModelQuantity = intModelQuantity
    End Sub

    Public Overrides Function ToString() As String

    End Function
End Class
