Imports MySql.Data.MySqlClient
Imports System.Data


Public Class Connectdb


    Private _connetion As New MySqlConnection
    Public Property Connetion As MySqlConnection
        Get
            Return _connetion
        End Get
        Set(value As MySqlConnection)
            _connetion = value
        End Set
    End Property

    Public Sub New(connetion As MySqlConnection)
        _connetion = connetion
    End Sub

    Public Sub New()
         Dim conectionString As String = "server=localhost;database=;uid=root;password=;"
        Connetion = New MySqlConnection(conectionString)
    End Sub

    Public Function ConnectionClose()
        If Connetion.State = ConnectionState.Open Then
            Connetion.Close()
            Return True
        End If
        Return False
    End Function

    Public Function ConnectionOpen()
        Try
            If Connetion.State = ConnectionState.Closed Then
                Connetion.Open()
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Echec de connection àla base de donnés")
        End Try
        Return False
    End Function

End Class
