Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel

Public Class MainFrame
    Dim Ports As Array
    Delegate Sub SetTextCallBack(ByVal [text] As String)

    Private Sub MainFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ports = SerialPort.GetPortNames()
        PortBox.Items.AddRange(Ports)
        WriteButton.Enabled = False
        CloseButton.Enabled = False
    End Sub

    Private Sub WriteButton_Click(sender As Object, e As EventArgs) Handles WriteButton.Click
        TheSerialPort.Write(InputText.Text & vbCr)
    End Sub

    Private Sub InitButton_Click(sender As Object, e As EventArgs) Handles InitButton.Click
        Try
            TheSerialPort.PortName = PortBox.Text
            TheSerialPort.BaudRate = BaudBox.Text
            TheSerialPort.Open()

            InitButton.Enabled = False
            WriteButton.Enabled = True
            CloseButton.Enabled = True
        Catch
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        TheSerialPort.Close()

        InitButton.Enabled = True
        WriteButton.Enabled = False
        CloseButton.Enabled = False
    End Sub

    Private Sub TheSerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles TheSerialPort.DataReceived
        ReceivedText(TheSerialPort.ReadExisting())
    End Sub

    Private Sub ReceivedText(ByVal [Text] As String)
        If OutputText.InvokeRequired Then
            Dim data As New SetTextCallBack(AddressOf ReceivedText)
            Invoke(data, New Object() {(Text)})
        Else
            OutputText.Text &= [Text]
        End If
    End Sub
End Class
