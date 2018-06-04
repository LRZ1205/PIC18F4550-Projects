Public Class frmUSB
    ' vendor and product IDs
    Private Const VendorID As Integer = &H1205   'Replace with your device's
    Private Const ProductID As Integer = &H1      'product and vendor IDs

    ' read and write buffers
    Private Const BufferInSize As Integer = 64 'Size of the data buffer coming IN to the PC
    Private Const BufferOutSize As Integer = 64    'Size of the data buffer going OUT from the PC
    Dim BufferIn(BufferInSize) As Byte          'Received data will be stored here - the first byte in the array is unused
    Dim BufferOut(BufferOutSize) As Byte    'Transmitted data is stored here - the first item in the array must be 0
    Dim ADC1, ADC2 As Long

    Dim x, y, n, m As Double
   
    Dim array(1023) As Integer
    Dim i As Integer
    ' ****************************************************************
    ' when the form loads, connect to the HID controller - pass
    ' the form window handle so that you can receive notification
    ' events...
    '*****************************************************************
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' do not remove!
        ConnectToHID(Me)
       
        x = 0
        y = 0
        n = 0
        m = 0
        Chart1.Series.Clear()
        Chart1.Series.Add("ADC")
        Chart1.ChartAreas("ChartArea1").AxisX.Minimum = 0
        Chart1.ChartAreas("ChartArea1").AxisX.Maximum = 100
        Chart1.ChartAreas("ChartArea1").AxisX.Interval = 10
        Chart1.ChartAreas("ChartArea1").AxisX.Title = "x"
        Chart1.ChartAreas("ChartArea1").AxisY.Minimum = -0
        Chart1.ChartAreas("ChartArea1").AxisY.Maximum = 1100
        Chart1.ChartAreas("ChartArea1").AxisY.Interval = 100
        Chart1.ChartAreas("ChartArea1").AxisY.Title = "y"
        Chart1.Series("ADC").ChartType = DataVisualization.Charting.SeriesChartType.Line




        Chart2.Series.Clear()
        Chart2.Series.Add("ADC")
        Chart2.ChartAreas("ChartArea1").AxisX.Minimum = 0
        Chart2.ChartAreas("ChartArea1").AxisX.Maximum = 100
        Chart2.ChartAreas("ChartArea1").AxisX.Interval = 10
        Chart2.ChartAreas("ChartArea1").AxisX.Title = "x"
        Chart2.ChartAreas("ChartArea1").AxisY.Minimum = 0
        Chart2.ChartAreas("ChartArea1").AxisY.Maximum = 1100
        Chart2.ChartAreas("ChartArea1").AxisY.Interval = 100
        Chart2.ChartAreas("ChartArea1").AxisY.Title = "y"
        Chart2.Series("ADC").ChartType = DataVisualization.Charting.SeriesChartType.Line

        Timer1.Interval = 100
        Timer2.Interval = 100
       
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
            ADC1 = Val(BufferIn(4)) + (Val(BufferIn(3)) << 8)
            ADC2 = Val(BufferIn(4)) + (Val(BufferIn(3)) << 8)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        x = x + 1

        Chart1.Series("ADC").Points.AddXY(x, ADC1)

        If x = 100 Then

            n = 1

        End If

        If n = 1 Then
            m = m + 1
            Chart1.ChartAreas("ChartArea1").AxisX.Minimum = m
            Chart1.ChartAreas("ChartArea1").AxisX.Maximum = x
            Chart1.ChartAreas("ChartArea1").AxisY.Interval = 100

            Chart1.ResetAutoValues()
        End If
        TextBox1.Text = ADC1
        TextBox2.Text = ADC2


    End Sub

    Private Sub NumericUpDown()
        Throw New NotImplementedException
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Timer1.Start()
        Timer2.Start()
        If B1.Text = "Iniciar" Then
            B1.Text = "Reanudar"


        End If
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        y = y + 1
        Chart2.Series("ADC").Points.AddXY(y, ADC2)
        If y = 100 Then

            Chart2.Series("ADC").Points.Clear()

            y = 0
        End If

    End Sub
End Class
