Imports QueryMaster.GameServer

Public Class Form1
    Dim Server As Server
    Dim ServerInfo As ServerInfo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icon
        TxtIP.Text = "192.168.0.100:27015"
        Disconected()
    End Sub

    Private Sub CmdConnect_Click(sender As Object, e As EventArgs) Handles CmdConnect.Click
        Dim IP As String = TxtIP.Text.Split(":")(0)
        Dim Port As UShort = UShort.Parse(TxtIP.Text.Split(":")(1))
        Server = ServerQuery.GetServerInstance(QueryMaster.EngineType.GoldSource, IP, Port)
        ServerInfo = Server.GetInfo
        If Server.GetControl(TxtRcon.Text) Then
            Connected()
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
            Disconected()
        End If
    End Sub

    Private Sub TxtCmd_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCmd.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtConsole.AppendText(Server.Rcon.SendCommand(TxtCmd.Text).Replace(vbLf, vbCrLf))
            TxtCmd.Clear()
        End If
    End Sub


    Private Sub Connected()
        TxtCmd.Enabled = True
        TxtConsole.Enabled = True
        LblStatus.Text = "Connected"
        LblStatus.ForeColor = Color.DarkGreen
        Me.Text = "CS Rcon - " + ServerInfo.Name
    End Sub

    Private Sub Disconected()
        TxtCmd.Enabled = False
        TxtConsole.Enabled = False
        LblStatus.Text = "Disconnected"
        LblStatus.ForeColor = Color.Red
        Me.Text = "CS Rcon"
    End Sub

End Class
