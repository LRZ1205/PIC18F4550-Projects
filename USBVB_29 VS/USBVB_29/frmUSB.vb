Public Class frmUSB
    ' vendor and product IDs
    Private Const VendorID As Integer = &H1205    'Replace with your device's
    Private Const ProductID As Integer = &H1      'product and vendor IDs

    ' read and write buffers
    Private Const BufferInSize As Integer = 64 'Size of the data buffer coming IN to the PC
    Private Const BufferOutSize As Integer = 64    'Size of the data buffer going OUT from the PC
    Dim BufferIn(BufferInSize) As Byte          'Received data will be stored here - the first byte in the array is unused
    Dim BufferOut(BufferOutSize) As Byte    'Transmitted data is stored here - the first item in the array must be 0
    Dim dato_n As Byte
    Dim dato1 As Byte
    Dim dato2 As Byte
    Dim needle As Long
    Dim val_pwm As Long
    Dim ADC1 As Long
    Dim vuelta As Long
    Dim high As Long
    Dim low As Long
    Dim flag As ULong

    ' ****************************************************************
    ' when the form loads, connect to the HID controller - pass
    ' the form window handle so that you can receive notification
    ' events...
    '*****************************************************************
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' do not remove!
        ConnectToHID(Me)
        Timer1.Interval = 60
        Timer1.Enabled = False
        Timer2.Interval = 60
        Timer2.Enabled = False
        high = 0
        low = 0
        flag = 0
    End Sub

    '*****************************************************************
    ' disconnect from the HID controller...
    '*****************************************************************
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        DisconnectFromHID()
    End Sub

    '*****************************************************************
    ' a HID device has been plugged in...
    '*****************************************************************
    Public Sub OnPlugged(ByVal pHandle As Integer)
        If hidGetVendorID(pHandle) = VendorID And hidGetProductID(pHandle) = ProductID Then
            ' ** YOUR CODE HERE **
        End If
    End Sub

    '*****************************************************************
    ' a HID device has been unplugged...
    '*****************************************************************
    Public Sub OnUnplugged(ByVal pHandle As Integer)
        If hidGetVendorID(pHandle) = VendorID And hidGetProductID(pHandle) = ProductID Then
            hidSetReadNotify(hidGetHandle(VendorID, ProductID), False)
            ' ** YOUR CODE HERE **
        End If
    End Sub

    '*****************************************************************
    ' controller changed notification - called
    ' after ALL HID devices are plugged or unplugged
    '*****************************************************************
    Public Sub OnChanged()
        ' get the handle of the device we are interested in, then set
        ' its read notify flag to true - this ensures you get a read
        ' notification message when there is some data to read...
        Dim pHandle As Integer
        pHandle = hidGetHandle(VendorID, ProductID)
        hidSetReadNotify(hidGetHandle(VendorID, ProductID), True)
    End Sub

    '*****************************************************************
    ' on read event...
    '*****************************************************************
    Public Sub OnRead(ByVal pHandle As Integer)
        ' read the data (don't forget, pass the whole array)...
        If hidRead(pHandle, BufferIn(0)) Then
            ' ** YOUR CODE HERE **
            ' first byte is the report ID, e.g. BufferIn(0)
            ' the other bytes are the data from the microcontroller...
            ADC1 = Val(BufferIn(2)) + (Val(BufferIn(3)) << 8)

            If flag = 1 Then
                high = 0
                low = 0
                flag = 0
            ElseIf ADC1 <= 50 Then
                high = 1
            Else
                low = 1
            End If

            If high = 1 And low = 1 Then
                flag = 1
                vuelta += 1

            End If


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Red
        Button3.BackColor = Color.Gray
        Button2.BackColor = Color.Gray

        'dato1 = Convert.ToByte(val_pwm)
        'BufferOut(4) = dato1
        BufferOut(2) = &H1
        hidWriteEx(VendorID, ProductID, BufferOut(0))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.BackColor = Color.Red
        Button1.BackColor = Color.Gray
        Button3.BackColor = Color.Gray
        BufferOut(2) = &H2
        hidWriteEx(VendorID, ProductID, BufferOut(0))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button3.BackColor = Color.Red
        Button1.BackColor = Color.Gray
        Button2.BackColor = Color.Gray
        BufferOut(2) = &H0
        hidWriteEx(VendorID, ProductID, BufferOut(0))
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll

        val_pwm = VScrollBar1.Value
        Label1.Text = val_pwm
        needle = ((val_pwm * 100.0) / 255.0)

        Label2.Text = needle
        GaugeControl2.SetPointerValue("Pointer1", needle)

        dato2 = Convert.ToByte(val_pwm)

        BufferOut(3) = dato2
        hidWriteEx(VendorID, ProductID, BufferOut(0))
    End Sub



    Private Sub GaugeControl1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BufferOut(2) = &H3
        hidWriteEx(VendorID, ProductID, BufferOut(0))

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        BufferOut(2) = &H4
        hidWriteEx(VendorID, ProductID, BufferOut(0))
    End Sub




End Class
