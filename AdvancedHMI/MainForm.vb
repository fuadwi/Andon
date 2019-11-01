Public Class MainForm
    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    '***************************************************************
    '* .NET does not close hidden forms, so do it here
    '* to make sure forms are disposed and drivers close
    '***************************************************************
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub
    Private Sub QuickStartLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub PilotLight1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PilotLight2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MessageListByBit1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MessageListByValue1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BarLevel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)
        SPVForm.Show()
        Me.Visible = False

    End Sub

    

    Private Sub KeyboardInput3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BarLevel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        




    End Sub

    Private Sub MessageDisplayByBit1_DoubleClick(sender As Object, e As EventArgs)
        Password.Show()



    End Sub


    Private Sub MessageDisplayByBit2_DoubleClick(sender As Object, e As EventArgs)
        Password.Show()
    End Sub

    Private Sub AnalogValueDisplay2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MessageDisplayByBit3_Click(sender As Object, e As EventArgs) Handles MessageDisplayByBit3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        AnalogValueDisplay2.Text = (Val(AnalogValueDisplay1.Text) / Val(AnalogValueDisplay3.Text)) * 100
        AnalogValueDisplay2.Text = FormatNumber(AnalogValueDisplay2.Text, 2)
        If Val(AnalogValueDisplay2.Text) > 100 Then
            AnalogValueDisplay2.Text = "99,99"
        End If
        If Val(AnalogValueDisplay2.Text) >= 80 Then
            AnalogValueDisplay2.ForeColor = Color.Green
        ElseIf Val(AnalogValueDisplay2.Text) >= 60 Then
            AnalogValueDisplay2.ForeColor = Color.Yellow
        ElseIf Val(AnalogValueDisplay2.Text) < 60 Then
            AnalogValueDisplay2.ForeColor = Color.Red
        End If

    End Sub

    Private Sub MessageDisplayByBit5_DoubleClick(sender As Object, e As EventArgs) Handles MessageDisplayByBit5.DoubleClick

        Password.Show()
    End Sub

    Private Sub MessageDisplayByBit4_DoubleClick(sender As Object, e As EventArgs) Handles MessageDisplayByBit4.DoubleClick
        Password.Show()
    End Sub

    Private Sub MessageDisplayByBit5_Click(sender As Object, e As EventArgs) Handles MessageDisplayByBit5.Click

    End Sub
End Class
