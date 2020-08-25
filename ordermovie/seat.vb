Public Class seat

    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.gray)
    Dim provisionalIcon As New System.Drawing.Bitmap(My.Resources.green)
    Private Sub seat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = availableIcon
                AddHandler c.Click, AddressOf picC3_Click
            End If
        Next

        'Dim stSQL As String
        'stSQL = "SELECT BookingID, CustomerID, SeatID FROM tblBookings"

        'Dim stConString As String
        'stConString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\Acer\source\repos\movie seat\Database.accdb"

        'Dim conBookings As OleDbConnection
        'conBookings = New OleDbConnection
        'conBookings.ConnectionString = stConString
        'conBookings.Open()

        'Dim cmdSelectBookings As OleDbCommand
        'cmdSelectBookings = New OleDbCommand
        'cmdSelectBookings.CommandText = stSQL
        'cmdSelectBookings.Connection = conBookings

        'Dim dsBookings As New DataSet
        'Dim daBookings As New OleDbDataAdapter(cmdSelectBookings)
        'daBookings.Fill(dsBookings, "Bookings")
        'conBookings.Close()

        'MsgBox(dsBookings.Tables("Bookings").Rows.Count)

    End Sub
    Private Sub picC3_Click(sender As Object, e As EventArgs)
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = provisionalIcon
        ElseIf CType(sender, PictureBox).Image Is provisionalIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

End Class