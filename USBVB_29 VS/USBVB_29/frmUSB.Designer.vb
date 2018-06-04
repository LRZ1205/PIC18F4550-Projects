<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUSB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GaugeCircularScale1 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale()
        Dim GaugePointer1 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer()
        Dim GaugeRange1 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange()
        Dim GaugeSection1 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection()
        Dim GradientFillColor1 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor()
        Dim GradientFillColor2 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUSB))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GaugeControl1 = New DevComponents.Instrumentation.GaugeControl()
        Me.GaugeControl2 = New DevComponents.Instrumentation.GaugeControl()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GaugeControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GaugeControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(277, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Derecha"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Izquierda"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(144, 301)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 28)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Parar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(355, 13)
        Me.VScrollBar1.Maximum = 255
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(21, 272)
        Me.VScrollBar1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Control de Velocidad"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.USBVB_29.My.Resources.Resources.esime_original
        Me.PictureBox2.Location = New System.Drawing.Point(717, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(113, 109)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.USBVB_29.My.Resources.Resources.LOGOTIPO_IPN
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(147, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(548, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Interfaz USB que modifica PWM en el PIF18F4550"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "% de PWM"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(115, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "PWM en Decimal"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GaugeControl2)
        Me.Panel1.Controls.Add(Me.VScrollBar1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(219, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 406)
        Me.Panel1.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 489)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(310, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Developer : Luis Romero Zepeda"
        '
        'GaugeControl1
        '
        Me.GaugeControl1.Location = New System.Drawing.Point(0, 0)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(250, 250)
        Me.GaugeControl1.TabIndex = 0
        '
        'GaugeControl2
        '
        GaugeCircularScale1.MaxPin.Name = "MaxPin"
        GaugeCircularScale1.MinPin.Name = "MinPin"
        GaugeCircularScale1.Name = "Scale1"
        GaugePointer1.CapFillColor.BorderColor = System.Drawing.Color.DimGray
        GaugePointer1.CapFillColor.BorderWidth = 1
        GaugePointer1.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
        GaugePointer1.CapFillColor.Color2 = System.Drawing.Color.DimGray
        GaugePointer1.FillColor.BorderColor = System.Drawing.Color.DimGray
        GaugePointer1.FillColor.BorderWidth = 1
        GaugePointer1.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
        GaugePointer1.FillColor.Color2 = System.Drawing.Color.Red
        GaugePointer1.Length = 0.358!
        GaugePointer1.Name = "Pointer1"
        GaugePointer1.Style = DevComponents.Instrumentation.PointerStyle.Needle
        GaugeCircularScale1.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer1})
        GaugeRange1.FillColor.BorderColor = System.Drawing.Color.DimGray
        GaugeRange1.FillColor.BorderWidth = 1
        GaugeRange1.FillColor.Color1 = System.Drawing.Color.Lime
        GaugeRange1.FillColor.Color2 = System.Drawing.Color.Red
        GaugeRange1.Name = "Range1"
        GaugeRange1.ScaleOffset = 0.28!
        GaugeRange1.StartValue = 70.0R
        GaugeCircularScale1.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange1})
        GaugeSection1.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
        GaugeSection1.FillColor.Color2 = System.Drawing.Color.Purple
        GaugeSection1.Name = "Section1"
        GaugeCircularScale1.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection1})
        Me.GaugeControl2.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale1})
        GradientFillColor1.Color1 = System.Drawing.Color.Gainsboro
        GradientFillColor1.Color2 = System.Drawing.Color.DarkGray
        Me.GaugeControl2.Frame.BackColor = GradientFillColor1
        GradientFillColor2.BorderColor = System.Drawing.Color.Gainsboro
        GradientFillColor2.BorderWidth = 1
        GradientFillColor2.Color1 = System.Drawing.Color.White
        GradientFillColor2.Color2 = System.Drawing.Color.DimGray
        Me.GaugeControl2.Frame.FrameColor = GradientFillColor2
        Me.GaugeControl2.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
        Me.GaugeControl2.Location = New System.Drawing.Point(83, 25)
        Me.GaugeControl2.Name = "GaugeControl2"
        Me.GaugeControl2.Size = New System.Drawing.Size(243, 260)
        Me.GaugeControl2.TabIndex = 15
        Me.GaugeControl2.Text = "GaugeControl2"
        '
        'frmUSB
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 520)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUSB"
        Me.Text = " "
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GaugeControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GaugeControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Private WithEvents GaugeControl1 As DevComponents.Instrumentation.GaugeControl
    Friend WithEvents GaugeControl2 As DevComponents.Instrumentation.GaugeControl
End Class
