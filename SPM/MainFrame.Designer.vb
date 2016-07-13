<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrame
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
        Me.WriteButton = New System.Windows.Forms.Button()
        Me.InitButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.PortBox = New System.Windows.Forms.ComboBox()
        Me.BaudBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InputText = New System.Windows.Forms.RichTextBox()
        Me.OutputText = New System.Windows.Forms.RichTextBox()
        Me.TheSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'WriteButton
        '
        Me.WriteButton.Location = New System.Drawing.Point(0, 0)
        Me.WriteButton.Name = "WriteButton"
        Me.WriteButton.Size = New System.Drawing.Size(75, 23)
        Me.WriteButton.TabIndex = 0
        Me.WriteButton.Text = "Write"
        Me.WriteButton.UseVisualStyleBackColor = True
        '
        'InitButton
        '
        Me.InitButton.Location = New System.Drawing.Point(81, 0)
        Me.InitButton.Name = "InitButton"
        Me.InitButton.Size = New System.Drawing.Size(75, 23)
        Me.InitButton.TabIndex = 1
        Me.InitButton.Text = "Init"
        Me.InitButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(162, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'PortBox
        '
        Me.PortBox.FormattingEnabled = True
        Me.PortBox.Location = New System.Drawing.Point(75, 48)
        Me.PortBox.Name = "PortBox"
        Me.PortBox.Size = New System.Drawing.Size(121, 21)
        Me.PortBox.TabIndex = 3
        '
        'BaudBox
        '
        Me.BaudBox.FormattingEnabled = True
        Me.BaudBox.Items.AddRange(New Object() {"2400", "4800", "9600", "19200"})
        Me.BaudBox.Location = New System.Drawing.Point(308, 48)
        Me.BaudBox.Name = "BaudBox"
        Me.BaudBox.Size = New System.Drawing.Size(121, 21)
        Me.BaudBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Baud"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Input"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Output"
        '
        'InputText
        '
        Me.InputText.Location = New System.Drawing.Point(75, 84)
        Me.InputText.Name = "InputText"
        Me.InputText.Size = New System.Drawing.Size(459, 96)
        Me.InputText.TabIndex = 9
        Me.InputText.Text = ""
        '
        'OutputText
        '
        Me.OutputText.Location = New System.Drawing.Point(75, 186)
        Me.OutputText.Name = "OutputText"
        Me.OutputText.Size = New System.Drawing.Size(459, 96)
        Me.OutputText.TabIndex = 10
        Me.OutputText.Text = ""
        '
        'TheSerialPort
        '
        '
        'MainFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 301)
        Me.Controls.Add(Me.OutputText)
        Me.Controls.Add(Me.InputText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BaudBox)
        Me.Controls.Add(Me.PortBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.InitButton)
        Me.Controls.Add(Me.WriteButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainFrame"
        Me.Text = "Serial Port Monitor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WriteButton As Button
    Friend WithEvents InitButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents PortBox As ComboBox
    Friend WithEvents BaudBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents InputText As RichTextBox
    Friend WithEvents OutputText As RichTextBox
    Friend WithEvents TheSerialPort As IO.Ports.SerialPort
End Class
