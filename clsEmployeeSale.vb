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
End Class
